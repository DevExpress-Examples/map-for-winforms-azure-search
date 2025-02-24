Imports DevExpress.XtraMap
Imports DevExpress.XtraPrinting.Native
Imports System.Text

Namespace AzureMapSearch

    Public Partial Class Form1
        Inherits Form

        Const azureKey As String = "your key"

        Private azureSearchProvider As DevExpress.XtraMap.AzureSearchDataProvider

        Public Sub New()
            Me.InitializeComponent()
            Me.imageLayer1.DataProvider = New DevExpress.XtraMap.AzureMapDataProvider() With {.AzureKey = AzureMapSearch.Form1.azureKey, .Tileset = DevExpress.XtraMap.AzureTileset.Imagery}
            Me.imageLayer2.DataProvider = New DevExpress.XtraMap.AzureMapDataProvider() With {.AzureKey = AzureMapSearch.Form1.azureKey, .Tileset = DevExpress.XtraMap.AzureTileset.BaseLabelsRoad}
            Me.azureSearchProvider = New DevExpress.XtraMap.AzureSearchDataProvider() With {.AzureKey = AzureMapSearch.Form1.azureKey}
            Me.informationLayer1.DataProvider = Me.azureSearchProvider
            Me.informationLayer1.DataRequestCompleted += AddressOf OnDataRequestCompleted
            Me.azureSearchProvider.SearchCompleted += New DevExpress.XtraMap.AzureSearchCompletedEventHandler(AddressOf OnSearchCompleted)
            Me.mapControl1.SearchPanelOptions.Visible = False
        End Sub

        Private Sub OnDataRequestCompleted(ByVal sender As Object, ByVal e As DevExpress.XtraMap.RequestCompletedEventArgs)
            Me.mapControl1.ZoomToFitLayerItems(0.4)
        End Sub

        Private Sub OnSearchCompleted(ByVal sender As Object, ByVal e As DevExpress.XtraMap.AzureSearchCompletedEventArgs)
            If e.Cancelled Then Return
            If e.RequestResult.ResultCode IsNot DevExpress.XtraMap.RequestResultCode.Success Then
                Me.memoEdit1.Text = "The Bing Search service does not work for this location."
                Return
            End If

            Dim resultList As StringBuilder = New StringBuilder("")
            Dim resCounter As Integer = 1
            For Each resultInfo As DevExpress.XtraMap.LocationInformation In e.RequestResult.SearchResults
                resultList.Append([String].Format("Result {0}:  " & Global.Microsoft.VisualBasic.Constants.vbCrLf, resCounter))
                resultList.Append([String].Format("Address: {0}" & Global.Microsoft.VisualBasic.Constants.vbCrLf, resultInfo.Address.FormattedAddress))
                resultList.Append([String].Format("Geographic coordinates:  {0}" & Global.Microsoft.VisualBasic.Constants.vbCrLf, resultInfo.Location))
                resultList.Append([String].Format("__________________" & Global.Microsoft.VisualBasic.Constants.vbCrLf))
                resCounter += 1
            Next

            Me.memoEdit1.Text = resultList.ToString()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.azureSearchProvider.Search(Me.textEdit1.Text, maxResults:=2)
        End Sub
    End Class
End Namespace
