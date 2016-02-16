Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Xml.Serialization

<System.ComponentModel.TypeConverter(GetType(System.ComponentModel.ExpandableObjectConverter)), System.Serializable()>
    Public Class MusicItem
        Private _artWork As Image

        Sub Setdata(_id As String, _title As String, _artist As String, _album As String, _artWork As Image)
            ID = _id
            Title = _title
            Artist = _artist
            Album = _album
            ArtWork = _artWork
        End Sub
        Property ID As String
        Property Title As String
        Property Artist As String
        Property Album As String

        <XmlIgnore>
        Property ArtWork As Image
            Get
                Return _artWork
            End Get
            Set
                _artWork = value
            End Set
        End Property

        <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)> _
        <XmlElement("ArtWork")> _
        Public Property ArtWorkSerialized() As Byte()
	        Get
		        ' serialize
		        If ArtWork Is Nothing Then
			        Return Nothing
		        End If
		        Using ms As New MemoryStream()
			        ArtWork.Save(ms, ImageFormat.Jpeg)
			        Return ms.ToArray()
		        End Using
	        End Get
	        Set
		        ' deserialize
		        If value Is Nothing Then
			        ArtWork = Nothing
		        Else
			        Using ms As New MemoryStream(value)
				        ArtWork = New Bitmap(ms)
			        End Using
		        End If
	        End Set
        End Property

    End Class
