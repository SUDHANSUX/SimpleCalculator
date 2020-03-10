
// SmipleCalculatorDlg.cpp : implementation file
//

#include "stdafx.h"
#include "SmipleCalculator.h"
#include "SmipleCalculatorDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
END_MESSAGE_MAP()


// CSmipleCalculatorDlg dialog




CSmipleCalculatorDlg::CSmipleCalculatorDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSmipleCalculatorDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CSmipleCalculatorDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CSmipleCalculatorDlg, CDialog)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_BN_CLICKED(IDC_BUTTON_ADD, &CSmipleCalculatorDlg::OnBnClickedButtonAdd)
	ON_BN_CLICKED(IDC_BUTTON_SUB, &CSmipleCalculatorDlg::OnBnClickedButtonSub)
	ON_BN_CLICKED(IDC_BUTTON_MUL, &CSmipleCalculatorDlg::OnBnClickedButtonMul)
	ON_BN_CLICKED(IDC_BUTTON_DIV, &CSmipleCalculatorDlg::OnBnClickedButtonDiv)
	ON_BN_CLICKED(IDC_BUTTON_CLEAR, &CSmipleCalculatorDlg::OnBnClickedButtonClear)
END_MESSAGE_MAP()


// CSmipleCalculatorDlg message handlers

BOOL CSmipleCalculatorDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CSmipleCalculatorDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CSmipleCalculatorDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CSmipleCalculatorDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CSmipleCalculatorDlg::OnBnClickedButtonAdd()
{
	// TODO: Add your control notification handler code here
	int nFirstNo = this->GetDlgItemInt(IDC_EDIT_FIRSTNO);
	int nSecondNo = this->GetDlgItemInt(IDC_EDIT_SECONDNO);
	int nResult = nFirstNo + nSecondNo;
	this->SetDlgItemInt(IDC_EDIT_RESULT, nResult);
}

void CSmipleCalculatorDlg::OnBnClickedButtonSub()
{
	// TODO: Add your control notification handler code here
	int nFirstNo = this->GetDlgItemInt(IDC_EDIT_FIRSTNO);
	int nSecondNo = this->GetDlgItemInt(IDC_EDIT_SECONDNO);
	int nResult = nFirstNo - nSecondNo;
	this->SetDlgItemInt(IDC_EDIT_RESULT, nResult);
}

void CSmipleCalculatorDlg::OnBnClickedButtonMul()
{
	// TODO: Add your control notification handler code here
	int nFirstNo = this->GetDlgItemInt(IDC_EDIT_FIRSTNO);
	int nSecondNo = this->GetDlgItemInt(IDC_EDIT_SECONDNO);
	int nResult = nFirstNo * nSecondNo;
	this->SetDlgItemInt(IDC_EDIT_RESULT, nResult);
}

void CSmipleCalculatorDlg::OnBnClickedButtonDiv()
{
	// TODO: Add your control notification handler code here
	int nFirstNo = this->GetDlgItemInt(IDC_EDIT_FIRSTNO);
	int nSecondNo = this->GetDlgItemInt(IDC_EDIT_SECONDNO);
	if(nSecondNo != 0)
	{
		int nResult = nFirstNo / nSecondNo;
		this->SetDlgItemInt(IDC_EDIT_RESULT, nResult);
	}
	else
	{
		this->SetDlgItemText(IDC_EDIT_RESULT, _T("Error"));
	}
}

void CSmipleCalculatorDlg::OnBnClickedButtonClear()
{
	// TODO: Add your control notification handler code here
	this->SetDlgItemText(IDC_EDIT_FIRSTNO, _T(""));
	this->SetDlgItemText(IDC_EDIT_SECONDNO, _T(""));
	this->SetDlgItemText(IDC_EDIT_RESULT, _T(""));
}
