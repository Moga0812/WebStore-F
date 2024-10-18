<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Library
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lstLibraryGames = New ListBox()
        picLibraryImage = New PictureBox()
        lblLibraryTitle = New Label()
        cmbLibraryFilter = New ComboBox()
        txtLibrarySearch = New TextBox()
        btnLibrarySearch = New Button()
        btnPlay = New Button()
        btnStore = New Button()
        CType(picLibraryImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstLibraryGames
        ' 
        lstLibraryGames.FormattingEnabled = True
        lstLibraryGames.ItemHeight = 15
        lstLibraryGames.Location = New Point(12, 105)
        lstLibraryGames.Name = "lstLibraryGames"
        lstLibraryGames.Size = New Size(194, 529)
        lstLibraryGames.TabIndex = 0
        ' 
        ' picLibraryImage
        ' 
        picLibraryImage.Location = New Point(233, 59)
        picLibraryImage.Name = "picLibraryImage"
        picLibraryImage.Size = New Size(349, 494)
        picLibraryImage.TabIndex = 1
        picLibraryImage.TabStop = False
        ' 
        ' lblLibraryTitle
        ' 
        lblLibraryTitle.AutoSize = True
        lblLibraryTitle.Location = New Point(233, 29)
        lblLibraryTitle.Name = "lblLibraryTitle"
        lblLibraryTitle.Size = New Size(29, 15)
        lblLibraryTitle.TabIndex = 2
        lblLibraryTitle.Text = "Title"
        ' 
        ' cmbLibraryFilter
        ' 
        cmbLibraryFilter.FormattingEnabled = True
        cmbLibraryFilter.Location = New Point(85, 76)
        cmbLibraryFilter.Name = "cmbLibraryFilter"
        cmbLibraryFilter.Size = New Size(121, 23)
        cmbLibraryFilter.TabIndex = 3
        ' 
        ' txtLibrarySearch
        ' 
        txtLibrarySearch.Location = New Point(12, 12)
        txtLibrarySearch.Name = "txtLibrarySearch"
        txtLibrarySearch.Size = New Size(194, 23)
        txtLibrarySearch.TabIndex = 4
        ' 
        ' btnLibrarySearch
        ' 
        btnLibrarySearch.Location = New Point(12, 41)
        btnLibrarySearch.Name = "btnLibrarySearch"
        btnLibrarySearch.Size = New Size(194, 29)
        btnLibrarySearch.TabIndex = 5
        btnLibrarySearch.Text = "Search"
        btnLibrarySearch.UseVisualStyleBackColor = True
        ' 
        ' btnPlay
        ' 
        btnPlay.Location = New Point(233, 559)
        btnPlay.Name = "btnPlay"
        btnPlay.Size = New Size(166, 70)
        btnPlay.TabIndex = 6
        btnPlay.Text = "Play"
        btnPlay.UseVisualStyleBackColor = True
        ' 
        ' btnStore
        ' 
        btnStore.Location = New Point(452, 583)
        btnStore.Name = "btnStore"
        btnStore.Size = New Size(130, 22)
        btnStore.TabIndex = 10
        btnStore.Text = "Store"
        btnStore.UseVisualStyleBackColor = True
        ' 
        ' Library
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(609, 641)
        Controls.Add(btnStore)
        Controls.Add(btnPlay)
        Controls.Add(btnLibrarySearch)
        Controls.Add(txtLibrarySearch)
        Controls.Add(cmbLibraryFilter)
        Controls.Add(lblLibraryTitle)
        Controls.Add(picLibraryImage)
        Controls.Add(lstLibraryGames)
        Name = "Library"
        Text = "Library"
        CType(picLibraryImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstLibraryGames As ListBox
    Friend WithEvents picLibraryImage As PictureBox
    Friend WithEvents lblLibraryTitle As Label
    Friend WithEvents cmbLibraryFilter As ComboBox
    Friend WithEvents txtLibrarySearch As TextBox
    Friend WithEvents btnLibrarySearch As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnStore As Button
End Class
