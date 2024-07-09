<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Title = New Label()
        Author = New Label()
        YearPublished = New Label()
        Genre = New Label()
        btnAdd = New Button()
        btnupdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        txtTitle = New TextBox()
        txtAuthor = New TextBox()
        txtYearPublished = New TextBox()
        txtGenre = New TextBox()
        dgvBooks = New DataGridView()
        CType(dgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Title.Location = New Point(29, 49)
        Title.Name = "Title"
        Title.Size = New Size(44, 21)
        Title.TabIndex = 0
        Title.Text = "Title"
        ' 
        ' Author
        ' 
        Author.AutoSize = True
        Author.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Author.Location = New Point(29, 108)
        Author.Name = "Author"
        Author.Size = New Size(63, 21)
        Author.TabIndex = 1
        Author.Text = "Author"
        ' 
        ' YearPublished
        ' 
        YearPublished.AutoSize = True
        YearPublished.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        YearPublished.Location = New Point(29, 171)
        YearPublished.Name = "YearPublished"
        YearPublished.Size = New Size(123, 21)
        YearPublished.TabIndex = 2
        YearPublished.Text = "Year Published"
        ' 
        ' Genre
        ' 
        Genre.AutoSize = True
        Genre.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Genre.Location = New Point(29, 238)
        Genre.Name = "Genre"
        Genre.Size = New Size(55, 21)
        Genre.TabIndex = 3
        Genre.Text = "Genre"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.ControlDark
        btnAdd.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(246, 363)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(111, 37)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add Book"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = SystemColors.ControlDark
        btnupdate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnupdate.Location = New Point(434, 363)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(108, 37)
        btnupdate.TabIndex = 5
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.ControlDark
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(635, 363)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(104, 37)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete Book"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.ControlDark
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(865, 363)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(84, 37)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(29, 73)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(170, 23)
        txtTitle.TabIndex = 8
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(29, 132)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(170, 23)
        txtAuthor.TabIndex = 9
        ' 
        ' txtYearPublished
        ' 
        txtYearPublished.Location = New Point(29, 195)
        txtYearPublished.Name = "txtYearPublished"
        txtYearPublished.Size = New Size(170, 23)
        txtYearPublished.TabIndex = 10
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(29, 262)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(170, 23)
        txtGenre.TabIndex = 11
        ' 
        ' dgvBooks
        ' 
        dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooks.Location = New Point(213, 73)
        dgvBooks.Name = "dgvBooks"
        dgvBooks.Size = New Size(757, 212)
        dgvBooks.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 550)
        Controls.Add(dgvBooks)
        Controls.Add(txtGenre)
        Controls.Add(txtYearPublished)
        Controls.Add(txtAuthor)
        Controls.Add(txtTitle)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnupdate)
        Controls.Add(btnAdd)
        Controls.Add(Genre)
        Controls.Add(YearPublished)
        Controls.Add(Author)
        Controls.Add(Title)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Author As Label
    Friend WithEvents YearPublished As Label
    Friend WithEvents Genre As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtYearPublished As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents dgvBooks As DataGridView

End Class
