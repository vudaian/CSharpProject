﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKiemPhieuChi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimKiemPhieuChi))
        Me.grbTimKiemTheo = New System.Windows.Forms.GroupBox
        Me.cboGiaTriTimKiem = New System.Windows.Forms.ComboBox
        Me.rdoHDMH = New System.Windows.Forms.RadioButton
        Me.rdoNhanVien = New System.Windows.Forms.RadioButton
        Me.rdoNgayPC = New System.Windows.Forms.RadioButton
        Me.rdoMaPC = New System.Windows.Forms.RadioButton
        Me.btnTimKiem = New System.Windows.Forms.Button
        Me.btnHuyBo = New System.Windows.Forms.Button
        Me.grbTimKiemTheo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbTimKiemTheo
        '
        Me.grbTimKiemTheo.Controls.Add(Me.cboGiaTriTimKiem)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoHDMH)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoNhanVien)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoNgayPC)
        Me.grbTimKiemTheo.Controls.Add(Me.rdoMaPC)
        Me.grbTimKiemTheo.Location = New System.Drawing.Point(1, -1)
        Me.grbTimKiemTheo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbTimKiemTheo.Name = "grbTimKiemTheo"
        Me.grbTimKiemTheo.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbTimKiemTheo.Size = New System.Drawing.Size(336, 95)
        Me.grbTimKiemTheo.TabIndex = 14
        Me.grbTimKiemTheo.TabStop = False
        Me.grbTimKiemTheo.Text = "Theo"
        '
        'cboGiaTriTimKiem
        '
        Me.cboGiaTriTimKiem.FormattingEnabled = True
        Me.cboGiaTriTimKiem.Location = New System.Drawing.Point(15, 51)
        Me.cboGiaTriTimKiem.Name = "cboGiaTriTimKiem"
        Me.cboGiaTriTimKiem.Size = New System.Drawing.Size(296, 24)
        Me.cboGiaTriTimKiem.TabIndex = 1
        '
        'rdoHDMH
        '
        Me.rdoHDMH.AutoSize = True
        Me.rdoHDMH.Location = New System.Drawing.Point(225, 22)
        Me.rdoHDMH.Name = "rdoHDMH"
        Me.rdoHDMH.Size = New System.Drawing.Size(105, 20)
        Me.rdoHDMH.TabIndex = 3
        Me.rdoHDMH.Text = "HĐ mua hàng"
        Me.rdoHDMH.UseVisualStyleBackColor = True
        '
        'rdoNhanVien
        '
        Me.rdoNhanVien.AutoSize = True
        Me.rdoNhanVien.Location = New System.Drawing.Point(146, 22)
        Me.rdoNhanVien.Name = "rdoNhanVien"
        Me.rdoNhanVien.Size = New System.Drawing.Size(82, 20)
        Me.rdoNhanVien.TabIndex = 2
        Me.rdoNhanVien.Text = "Nhân viên"
        Me.rdoNhanVien.UseVisualStyleBackColor = True
        '
        'rdoNgayPC
        '
        Me.rdoNgayPC.AutoSize = True
        Me.rdoNgayPC.Location = New System.Drawing.Point(86, 22)
        Me.rdoNgayPC.Name = "rdoNgayPC"
        Me.rdoNgayPC.Size = New System.Drawing.Size(56, 20)
        Me.rdoNgayPC.TabIndex = 1
        Me.rdoNgayPC.Text = "Ngày"
        Me.rdoNgayPC.UseVisualStyleBackColor = True
        '
        'rdoMaPC
        '
        Me.rdoMaPC.AutoSize = True
        Me.rdoMaPC.Checked = True
        Me.rdoMaPC.Location = New System.Drawing.Point(15, 22)
        Me.rdoMaPC.Name = "rdoMaPC"
        Me.rdoMaPC.Size = New System.Drawing.Size(66, 20)
        Me.rdoMaPC.TabIndex = 0
        Me.rdoMaPC.TabStop = True
        Me.rdoMaPC.Text = "Mã PC"
        Me.rdoMaPC.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(343, 10)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(90, 29)
        Me.btnTimKiem.TabIndex = 15
        Me.btnTimKiem.Text = "&Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Location = New System.Drawing.Point(343, 57)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(90, 29)
        Me.btnHuyBo.TabIndex = 16
        Me.btnHuyBo.Text = "&Hủy bỏ"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'frmTimKiemPhieuChi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 92)
        Me.Controls.Add(Me.grbTimKiemTheo)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimKiemPhieuChi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm phiếu chi"
        Me.grbTimKiemTheo.ResumeLayout(False)
        Me.grbTimKiemTheo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbTimKiemTheo As System.Windows.Forms.GroupBox
    Friend WithEvents cboGiaTriTimKiem As System.Windows.Forms.ComboBox
    Friend WithEvents rdoHDMH As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNhanVien As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNgayPC As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMaPC As System.Windows.Forms.RadioButton
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
End Class
