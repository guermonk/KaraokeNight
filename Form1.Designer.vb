<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnValue = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.cboSelectAction = New System.Windows.Forms.ComboBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 450)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(448, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Karaoke Music Night"
        '
        'btnValue
        '
        Me.btnValue.Location = New System.Drawing.Point(536, 244)
        Me.btnValue.Name = "btnValue"
        Me.btnValue.Size = New System.Drawing.Size(89, 22)
        Me.btnValue.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Elephant", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(437, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hourly Rental of Karaoke Room:"
        '
        'btnCost
        '
        Me.btnCost.Location = New System.Drawing.Point(416, 299)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(126, 37)
        Me.btnCost.TabIndex = 4
        Me.btnCost.Text = "Total Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(625, 299)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(126, 37)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Elephant", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTotalCost.Location = New System.Drawing.Point(426, 382)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 18)
        Me.lblTotalCost.TabIndex = 6
        '
        'cboSelectAction
        '
        Me.cboSelectAction.Font = New System.Drawing.Font("Elephant", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectAction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboSelectAction.FormattingEnabled = True
        Me.cboSelectAction.Items.AddRange(New Object() {"Song selection ($2.99 each)", "Hours in Private Karaoke Booth ($8.99 per hour)"})
        Me.cboSelectAction.Location = New System.Drawing.Point(408, 71)
        Me.cboSelectAction.Name = "cboSelectAction"
        Me.cboSelectAction.Size = New System.Drawing.Size(364, 25)
        Me.cboSelectAction.TabIndex = 7
        Me.cboSelectAction.Text = "Customize your fun for the night!"
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(533, 364)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(51, 17)
        Me.lblDisplay.TabIndex = 8
        Me.lblDisplay.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.cboSelectAction)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnValue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Karaoke Music Night"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnValue As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents cboSelectAction As ComboBox
    Friend WithEvents lblDisplay As Label
End Class
