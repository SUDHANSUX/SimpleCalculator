VERSION 5.00
Begin VB.Form MainForm 
   Caption         =   "Simple Calculator"
   ClientHeight    =   3015
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   5760
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   3015
   ScaleWidth      =   5760
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdClear 
      Caption         =   "Clear"
      Height          =   495
      Left            =   1800
      TabIndex        =   10
      Top             =   2280
      Width           =   1695
   End
   Begin VB.CommandButton cmdDiv 
      Caption         =   "/"
      Height          =   495
      Left            =   3840
      TabIndex        =   9
      Top             =   2280
      Width           =   1695
   End
   Begin VB.CommandButton cmdMul 
      Caption         =   "*"
      Height          =   495
      Left            =   3840
      TabIndex        =   8
      Top             =   1680
      Width           =   1695
   End
   Begin VB.CommandButton cmdSub 
      Caption         =   "-"
      Height          =   495
      Left            =   3840
      TabIndex        =   7
      Top             =   960
      Width           =   1695
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "+"
      Height          =   495
      Left            =   3840
      TabIndex        =   6
      Top             =   240
      Width           =   1695
   End
   Begin VB.TextBox txtResult 
      Height          =   495
      Left            =   1800
      TabIndex        =   5
      Top             =   1680
      Width           =   1695
   End
   Begin VB.TextBox txtSecondNo 
      Height          =   495
      Left            =   1800
      MaxLength       =   7
      TabIndex        =   4
      Top             =   960
      Width           =   1695
   End
   Begin VB.TextBox txtFirstNo 
      Height          =   495
      Left            =   1800
      MaxLength       =   7
      TabIndex        =   3
      Top             =   240
      Width           =   1695
   End
   Begin VB.Label lblResult 
      Caption         =   "Result"
      Height          =   255
      Left            =   360
      TabIndex        =   2
      Top             =   1800
      Width           =   1215
   End
   Begin VB.Label lblSecondNo 
      Caption         =   "Second No"
      Height          =   255
      Left            =   360
      TabIndex        =   1
      Top             =   1080
      Width           =   1215
   End
   Begin VB.Label lblForstNo 
      Caption         =   "First No"
      Height          =   255
      Left            =   360
      TabIndex        =   0
      Top             =   360
      Width           =   1215
   End
End
Attribute VB_Name = "MainForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim FirstNo As Currency
Dim SecondNo As Currency
Dim Result As Currency

Private Sub cmdClear_Click()
    txtFirstNo.Text = ""
    txtSecondNo.Text = ""
    txtResult.Text = ""
End Sub

Private Sub cmdAdd_Click()
    If IsNumeric(txtFirstNo.Text) And IsNumeric(txtSecondNo.Text) Then
        FirstNo = Val(txtFirstNo.Text)
        SecondNo = Val(txtSecondNo.Text)
        Result = FirstNo + SecondNo
        txtResult.Text = Result
    Else
        txtResult.Text = "Error: Invalid Input."
    End If
End Sub

Private Sub cmdSub_Click()
    If IsNumeric(txtFirstNo.Text) And IsNumeric(txtSecondNo.Text) Then
        FirstNo = Val(txtFirstNo.Text)
        SecondNo = Val(txtSecondNo.Text)
        Result = FirstNo - SecondNo
        txtResult.Text = Result
    Else
        txtResult.Text = "Error: Invalid Input."
    End If
End Sub

Private Sub cmdMul_Click()
    If IsNumeric(txtFirstNo.Text) And IsNumeric(txtSecondNo.Text) Then
        FirstNo = Val(txtFirstNo.Text)
        SecondNo = Val(txtSecondNo.Text)
        Result = FirstNo * SecondNo
        txtResult.Text = Result
    Else
        txtResult.Text = "Error: Invalid Input."
    End If
End Sub

Private Sub cmdDiv_Click()
    If IsNumeric(txtFirstNo.Text) And IsNumeric(txtSecondNo.Text) Then
        FirstNo = Val(txtFirstNo.Text)
        SecondNo = Val(txtSecondNo.Text)
        If SecondNo = 0 Then
            txtResult.Text = "Error: Divide By Zero."
        Else
            Result = FirstNo / SecondNo
            txtResult.Text = Result
        End If
    Else
        txtResult.Text = "Error: Invalid Input."
    End If
End Sub
