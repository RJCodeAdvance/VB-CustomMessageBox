<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMessageBox
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
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.labelCaption = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.labelMessage = New System.Windows.Forms.Label()
        Me.pictureBoxIcon = New System.Windows.Forms.PictureBox()
        Me.panelTitleBar.SuspendLayout()
        Me.panelButtons.SuspendLayout()
        Me.panelBody.SuspendLayout()
        CType(Me.pictureBoxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.panelTitleBar.Controls.Add(Me.labelCaption)
        Me.panelTitleBar.Controls.Add(Me.btnClose)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(350, 35)
        Me.panelTitleBar.TabIndex = 1
        '
        'labelCaption
        '
        Me.labelCaption.AutoSize = True
        Me.labelCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCaption.ForeColor = System.Drawing.Color.White
        Me.labelCaption.Location = New System.Drawing.Point(9, 8)
        Me.labelCaption.Name = "labelCaption"
        Me.labelCaption.Size = New System.Drawing.Size(86, 17)
        Me.labelCaption.TabIndex = 4
        Me.labelCaption.Text = "labelCaption"
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(310, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 35)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'panelButtons
        '
        Me.panelButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.panelButtons.Controls.Add(Me.button3)
        Me.panelButtons.Controls.Add(Me.button2)
        Me.panelButtons.Controls.Add(Me.button1)
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelButtons.Location = New System.Drawing.Point(0, 90)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(350, 60)
        Me.panelButtons.TabIndex = 2
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.SeaGreen
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.button3.Location = New System.Drawing.Point(231, 12)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(100, 35)
        Me.button3.TabIndex = 2
        Me.button3.Text = "button3"
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.SeaGreen
        Me.button2.FlatAppearance.BorderSize = 0
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.button2.Location = New System.Drawing.Point(125, 12)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(100, 35)
        Me.button2.TabIndex = 1
        Me.button2.Text = "button2"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.SeaGreen
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.button1.Location = New System.Drawing.Point(19, 12)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(100, 35)
        Me.button1.TabIndex = 0
        Me.button1.Text = "button1"
        Me.button1.UseVisualStyleBackColor = False
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelBody.Controls.Add(Me.labelMessage)
        Me.panelBody.Controls.Add(Me.pictureBoxIcon)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 35)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Padding = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.panelBody.Size = New System.Drawing.Size(350, 55)
        Me.panelBody.TabIndex = 3
        '
        'labelMessage
        '
        Me.labelMessage.AutoSize = True
        Me.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.labelMessage.Location = New System.Drawing.Point(50, 10)
        Me.labelMessage.MaximumSize = New System.Drawing.Size(600, 0)
        Me.labelMessage.Name = "labelMessage"
        Me.labelMessage.Padding = New System.Windows.Forms.Padding(5, 5, 10, 15)
        Me.labelMessage.Size = New System.Drawing.Size(110, 37)
        Me.labelMessage.TabIndex = 1
        Me.labelMessage.Text = "labelMessage"
        Me.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pictureBoxIcon
        '
        Me.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.pictureBoxIcon.Image = Global.CustomMessageBoxVB.My.Resources.Resources.chat
        Me.pictureBoxIcon.Location = New System.Drawing.Point(10, 10)
        Me.pictureBoxIcon.Name = "pictureBoxIcon"
        Me.pictureBoxIcon.Size = New System.Drawing.Size(40, 45)
        Me.pictureBoxIcon.TabIndex = 0
        Me.pictureBoxIcon.TabStop = False
        '
        'FormMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 150)
        Me.Controls.Add(Me.panelBody)
        Me.Controls.Add(Me.panelButtons)
        Me.Controls.Add(Me.panelTitleBar)
        Me.MinimumSize = New System.Drawing.Size(350, 150)
        Me.Name = "FormMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormMessageBox"
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        Me.panelButtons.ResumeLayout(False)
        Me.panelBody.ResumeLayout(False)
        Me.panelBody.PerformLayout()
        CType(Me.pictureBoxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelTitleBar As Panel
    Private WithEvents labelCaption As Label
    Private WithEvents btnClose As Button
    Private WithEvents panelButtons As Panel
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents panelBody As Panel
    Private WithEvents labelMessage As Label
    Private WithEvents pictureBoxIcon As PictureBox
End Class
