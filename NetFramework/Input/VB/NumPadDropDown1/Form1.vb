Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
  Friend WithEvents c1NumericEdit1 As C1.Win.C1Input.C1NumericEdit
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.c1NumericEdit1 = New C1.Win.C1Input.C1NumericEdit()
        CType(Me.c1NumericEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1NumericEdit1
        '
        Me.c1NumericEdit1.DropDownFormClassName = "NumPadDropDown1.NumPadDropDown"
        Me.c1NumericEdit1.Location = New System.Drawing.Point(8, 16)
        Me.c1NumericEdit1.Name = "c1NumericEdit1"
        Me.c1NumericEdit1.NumericInput = False
        Me.c1NumericEdit1.Size = New System.Drawing.Size(240, 20)
        Me.c1NumericEdit1.TabIndex = 1
        Me.c1NumericEdit1.Tag = Nothing
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(260, 225)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1NumericEdit1})
        Me.Name = "Form1"
        Me.Text = "Simple NumPad Dropdown"
        CType(Me.c1NumericEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
