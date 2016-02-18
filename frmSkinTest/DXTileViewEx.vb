
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Scrolling
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraGrid.Views.Tile.ViewInfo

<ToolboxItem(True)> _
Public Class MyGridControl
    Inherits GridControl

    Friend WithEvents GridView1 As Views.Grid.GridView

    Public ReadOnly Property OriginalMargin As Padding
        Get
            Return Me.DefaultMargin
        End Get
    End Property
    
    Protected Overrides Function CreateDefaultView() As BaseView
        Return CreateView("MyTileView")
    End Function
    Protected Overrides Sub RegisterAvailableViewsCore(collection As InfoCollection)
        MyBase.RegisterAvailableViewsCore(collection)
        collection.Add(New MyTileViewInfoRegistrator())
    End Sub

    Private Sub InitializeComponent()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me
        Me.GridView1.Name = "GridView1"
        '
        'MyGridControl
        '
        Me.MainView = Me.GridView1
        Me.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
End Class

Public Class MyTileView
    Inherits TileView
    Private _myBorderWidth As Integer=2
    Private _vScrollBar As VCrkScrollBar = Me.ScrollInfo.VScroll
    
    Public ReadOnly Property VScrollBar As VCrkScrollBar
        Get
            Return _vScrollBar
        End Get       
    End Property

    Public Property MyBorderWidth As Integer
        Get
            Return _myBorderWidth
        End Get
        Set
            _myBorderWidth = value
            
        End Set
    End Property

    Public Property HotTrackRow As Integer = GridControl.InvalidRowHandle

    Public Function GetTileViewItem(rowHandle) As TileViewItem
        Return TryCast(TryCast(Me.GetViewInfo(), ITileControl).ViewInfo, TileViewInfoCore).VisibleItems(rowHandle)
    End Function

    Public Sub New()
    End Sub

    Protected Overrides ReadOnly Property ViewName() As String
        Get
            Return "MyTileView"
        End Get
    End Property

    Public Function GetVScrollBar As VcrkScrollBar
        Return Me.ScrollInfo.VScroll
    End Function

    '// this is the protected unscaled grid margin -- needed for horizontal scaling below
    Public Function GetGridDefaultMargin As Padding
        Return CType(Me.GridControl, MyGridControl).OriginalMargin
    End Function

    '// get the size a tileviewitem needs to be, to horizontally fill the grid/tileview it lives in.
    Public Function GetHScaledTileViewItemSize(unScaledHeight As Single) As SizeF
        Dim a As Single = Me.GridControl.Width
        Dim b As Single = 0
        If _vScrollBar.Visible Then b = _vScrollBar.Width - Me.GetGridDefaultMargin.Right'+ _vScrollBar.Margin.Left
        Dim c As Single = Me.OptionsTiles.Padding.Horizontal
        Dim d As Single = Me.GetGridDefaultMargin.Horizontal
        Dim scaledWidth As Single = (a - b - c - d)/Me.GridControl.ScaleFactor.Width
        Dim scaledHeight = unScaledHeight/Me.GridControl.ScaleFactor.Height
        Return New SizeF(scaledWidth, scaledHeight)
    End Function

    Public Function SpringTileItemElementWidth(column As TileViewColumn, includeContextButtons As Boolean) As TileItemElement
        If Me.TileTemplate Is Nothing Or column.View Is Nothing Then Return Nothing
        Dim tileItemElement As TileItemElement = Me.TileTemplate(column.AbsoluteIndex)
        Dim w As Single = Me.ViewRect.Width - tileItemElement.TextLocation.X - Me.OptionsTiles.Padding.Right
        Dim cbOffset As Single=0
        If includeContextButtons Then
            For Each cBtn As DevExpress.Utils.ContextButton In Me.ContextButtons
                cbOffset += (cBtn.Glyph.Width*1.5) + cBtn.Padding.Horizontal + 6
            Next
        End If
        tileItemElement.Width =  ((w-cbOffset)/Me.GridControl.ScaleFactor.Width) 
        Return tileItemElement
    End Function
    '// set the tileviewitems to the size they need to be to horizonatllay fill the grid/tileview they live in.
    Public Function SetHScaledTileViewItemSize(unScaledHeight As Single) As SizeF
        Dim sizeF As SizeF = GetHScaledTileViewItemSize(unScaledHeight)
        Me.OptionsTiles.ItemSize = sizeF.ToSize
        Return SizeF
        
    End Function

    '// get the dimensions of a tileViewItem background image
    Public Function GetTileViewItemBackgroundBounds As Rectangle
        '// get the first item
        If Me.RowCount=0 Then Return New Rectangle(0,0,0,0)
        Dim item As TileViewItem = GetTileViewItem(0)
        Dim r As New Rectangle(item.Padding.Left, 
                               item.Padding.Right,
                               (Me.OptionsTiles.ItemSize.Width*Me.GridControl.ScaleFactor.Width )+item.Padding.Left,
                               (Me.OptionsTiles.ItemSize.Height*Me.GridControl.ScaleFactor.Height)+item.Padding.Top)
        Return r
    End Function

 End Class

Public Class MyTileViewInfoRegistrator
    Inherits TileViewInfoRegistrator
    Public Overrides ReadOnly Property ViewName() As String
        Get
            Return "MyTileView"
        End Get
    End Property
    Public Overrides Function CreateView(grid As GridControl) As BaseView
        Return New MyTileView()
    End Function
    Public Overrides Function CreateViewInfo(view As BaseView) As BaseViewInfo
        Return New MyTileViewInfo(TryCast(view, MyTileView))
    End Function
End Class

Public Class MyTileViewInfo
    Inherits TileViewInfo
    
    
    'Public Property MyBorderWidth As Integer
    '    Get
    '        Return _myBorderWidth
    '    End Get
    '    Set
    '        _myBorderWidth = value
    '    End Set
    'End Property

    Public Sub New(view As TileView)
        MyBase.New(view)
    End Sub

    Protected Overrides Function CreateViewInfoCore() As TileViewInfoCore
        Return New MyTileViewInfoCore(Me, TryCast(View, TileView))
    End Function

End Class

Public Class MyTileViewInfoCore
    Inherits TileViewInfoCore
    

    Public Sub New(owner As ITileControl, view As TileView)
        MyBase.New(owner, view)
        
    End Sub
    
    Protected Overrides ReadOnly Property SelectionWidth() As Integer
        Get
            Dim mbw As Integer = CType(Me.View, MyTileView).MyBorderWidth
            Return mbw
        End Get
    End Property
End Class
