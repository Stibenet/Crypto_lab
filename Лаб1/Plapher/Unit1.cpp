#include <vcl.h>
#include "stdio.h"
#include "conio.h"
#include "windows.h"
#pragma hdrstop
#include "Unit1.h"
#include "Unit2.h"
#pragma package(smart_init)
#pragma resource "*.dfm"

TForm1 *Form1;
AnsiString Al = "ABCDEFGHIJKLMNOPQRSTUVWXYZ�����Ũ��������������������������abcdefghijklmnopqrstuvwxyz�������������������������������� !@\"#�$;%^:&?*()-_+={}[]\\/<>.,~`0123456789";
AnsiString MyText = "";                                  // ��������� �����
AnsiString Key = "";                                     // ��������� ����
AnsiString R = "";                                       // ���������� �������
AnsiString ResText = "";                                 // ���������� �����
AnsiString Pust = "";                                    // ��������

char Resh[10][16];                                       // ������ ���� �������
AnsiString Dir;                                          // ���������� ���������� ���������



//****************************************************************************//
//* ��������� ������� ��� ��������� ����� �� ������                          *//
//****************************************************************************//
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
  Form1->Edit1->Text = "��������";
  Form1->Button1->Enabled = true;
  Form1->Button2->Enabled = true;
  Form1->Button3->Enabled = false;
  Form1->RadioButton1->Checked = true;
  Form1->Label2->Caption = Form1->Memo1->Text.Length();
  Form1->Label3->Caption = Form1->Memo2->Text.Length();
  Dir = GetCurrentDir();
}



//****************************************************************************//
//* ������� �������� ���������� �����                                        *//
//****************************************************************************//
void OpenText()
{
 if (!Form1->OpenDialog1->Execute())
 {
   MessageBox(NULL, "�� �������� ������� ����!", "��������� ������!", MB_OK);
   Form1->Memo1->Clear();
   Form1->Memo2->Clear();
   Form1->Memo3->Clear();
   Form1->Label2->Caption = Form1->Memo1->Text.Length();
   Form1->Label3->Caption = Form1->Memo2->Text.Length();
   Form1->Button2->Enabled = false;
   Form1->Button3->Enabled = false;
 }
 else
 {
   // �������� ��� ��������� �������
   Form1->ProgressBar1->Position = 0;
   Form1->Memo1->Clear();
   Form1->Memo2->Clear();
   Form1->Memo3->Clear();
   MyText = "";
   Key = "";
   R = "";
   ResText = "";
   Pust = "";
   for (int i=0; i<10; i++)
     for (int j=0; j<16; j++)
       Resh[i][j] = NULL;

   Form1->Memo1->Lines->LoadFromFile(Form1->OpenDialog1->FileName);
   Form1->Label2->Caption = Form1->Memo1->Text.Length();
   Form1->Label3->Caption = Form1->Memo2->Text.Length();
   Form1->Button2->Enabled = true;
   Form1->Button3->Enabled = false;
 }
}



//****************************************************************************//
//* ������� �������� ����� �� ��������� ��������� ����                       *//
//****************************************************************************//
bool CheckKey()
{
  for (int i=1; i<=Key.Length(); i++)
    for (int j=1; j <= Key.Length(); j++)
      if ((Key[i] == Key[j]) && (i != j))
        return false;

  return true;
}



//****************************************************************************//
//* ������� �������� � ������ ������� �� �����                               *//
//****************************************************************************//
void CreateR()
{
  Form1->Memo3->Clear();
  R = Key;

  AnsiString Alphabet = Al;
  for (int i=1; i<=Key.Length(); i++)
    for (int j=1; j<=Alphabet.Length(); j++)
      if (Key[i] == Alphabet[j])
        Alphabet = Alphabet.Delete(j,1);

  R += Alphabet;   // ������� ������ � ��������

  int num = 1;
  AnsiString Str = "";
  for (int i=0; i<10; i++)
  {
    Str = "";
    for (int j=0; j<16; j++)
    {
      Str += R[num];
      if (j != 16)
        Str += " ";
      num++;
    }
    Form1->Memo3->Lines->Add(Str);
  }

  // ��������� ������ ���� �������
  num = 1;
  for (int i=0; i<10; i++)
    for (int j=0; j<16; j++)
    {
      Resh[i][j] = R[num];
      num++;
    }
}



//****************************************************************************//
//* ������� ������ �������-��������                                          *//
//****************************************************************************//
void ChoosePust()
{
  int k = 0;
  int m = 1000;
  for (int i=1; i<=R.Length(); i++)
  {
    for (int j=1; j<=MyText.Length(); j++)
      if (R[i] == MyText[j])
        k++;

    if (k<m)
    {
      m = k;
      k = 0;
      Pust = R[i];
    }
  }
}



//****************************************************************************//
//* ������� ������� �������� � �������� ������ �� ��������                   *//
//****************************************************************************//
void EditText()
{
  ChoosePust();    // �������� ��������

  // ��������� �������� � ������������� ��������
  for (int i=1; i<MyText.Length(); i++)
    if (MyText[i] == MyText[i+1])
      MyText = MyText.Insert(Pust,i+1);

  // ��������� ����� �� �������� � ���� �� �� ������ ����� ��������� � ����� ��������
  int Len = MyText.Length();
  if (Len % 2 != 0)
    MyText += Pust;
}



//****************************************************************************//
//* ������� ���������� ������                                                *//
//****************************************************************************//
void Encrypt()
{
   ResText = "";
   Form1->ProgressBar1->Position = 0;
   Form1->ProgressBar1->Min = 0;
   Form1->ProgressBar1->Max = MyText.Length();
   // ������� ���� � ��������
   int ind_x1 = 0;
   int ind_y1 = 0;
   int ind_x2 = 0;
   int ind_y2 = 0;

   int k = 1;
   while (k<MyText.Length())
   {
      for (int i=0; i<10; i++)
        for (int j=0; j<16; j++)
        {
          if (MyText[k] == Resh[i][j])
          {
            ind_x1 = i;
            ind_y1 = j;
          }

          if (MyText[k+1] == Resh[i][j])
          {
            ind_x2 = i;
            ind_y2 = j;
          }
        }

     // ���� ����� ��������� � ����� ������
     if (ind_x1 == ind_x2)
     {
        if (ind_y1 == 15)
        {
          ResText += Resh[ind_x1][0];
          ResText += Resh[ind_x2][ind_y2+1];
        }
        else
        if (ind_y2 == 15)
        {
          ResText += Resh[ind_x1][ind_y1+1];
          ResText += Resh[ind_x2][0];
        }
        else
        {
          ResText += Resh[ind_x1][ind_y1+1];
          ResText += Resh[ind_x2][ind_y2+1];
        }
     }

     // ���� ����� ��������� � ����� �������
     if (ind_y1 == ind_y2)
     {
        if (ind_x1 == 9)
        {
          ResText += Resh[0][ind_y1];
          ResText += Resh[ind_x2+1][ind_y2];
        }
        else
        if (ind_x2 == 9)
        {
          ResText += Resh[ind_x1+1][ind_y1];
          ResText += Resh[0][ind_y2];
        }
        else
        {
          ResText += Resh[ind_x1+1][ind_y1];
          ResText += Resh[ind_x2+1][ind_y2];
        }
     }

     // ���� ����� ��������� � ������ ������� � ������ ��������
     if ((ind_x1 != ind_x2) && (ind_y1 != ind_y2))
     {
       ResText += Resh[ind_x1][ind_y2];
       ResText += Resh[ind_x2][ind_y1];
     }

     k = k + 2;
     Form1->ProgressBar1->StepBy(2);
   }
   Form1->Memo2->Lines->Add(ResText);
   Form1->Label3->Caption = Form1->Memo2->Text.Length();
   Form1->Button3->Enabled = true;
   MessageBox(NULL, "����� ������� ����������!", "�����!", MB_OK);
}



//****************************************************************************//
//* ������� ������������� ������                                             *//
//****************************************************************************//
void Decrypt()
{
   ResText = "";
   Form1->ProgressBar1->Position = 0;
   Form1->ProgressBar1->Min = 0;
   Form1->ProgressBar1->Max = MyText.Length();
   // ������� ���� � ��������
   int ind_x1 = 0;
   int ind_y1 = 0;
   int ind_x2 = 0;
   int ind_y2 = 0;

   int k = 1;
   while (k<MyText.Length()-2)
   {
      for (int i=0; i<10; i++)
        for (int j=0; j<16; j++)
        {
          if (MyText[k] == Resh[i][j])
          {
            ind_x1 = i;
            ind_y1 = j;
          }

          if (MyText[k+1] == Resh[i][j])
          {
            ind_x2 = i;
            ind_y2 = j;
          }
        }

     // ���� ����� ��������� � ����� ������
     if (ind_x1 == ind_x2)
     {
        if (ind_y1 == 0)
        {
          ResText += Resh[ind_x1][15];
          ResText += Resh[ind_x2][ind_y2-1];
        }
        else
        if (ind_y2 == 0)
        {
          ResText += Resh[ind_x1][ind_y1-1];
          ResText += Resh[ind_x2][15];
        }
        else
        {
          ResText += Resh[ind_x1][ind_y1-1];
          ResText += Resh[ind_x2][ind_y2-1];
        }
     }

     // ���� ����� ��������� � ����� �������
     if (ind_y1 == ind_y2)
     {
        if (ind_x1 == 0)
        {
          ResText += Resh[9][ind_y1];
          ResText += Resh[ind_x2-1][ind_y2];
        }
        else
        if (ind_x2 == 0)
        {
          ResText += Resh[ind_x1-1][ind_y1];
          ResText += Resh[9][ind_y2];
        }
        else
        {
          ResText += Resh[ind_x1-1][ind_y1];
          ResText += Resh[ind_x2-1][ind_y2];
        }
     }

     // ���� ����� ��������� � ������ ������� � ������ ��������
     if ((ind_x1 != ind_x2) && (ind_y1 != ind_y2))
     {
       ResText += Resh[ind_x1][ind_y2];
       ResText += Resh[ind_x2][ind_y1];
     }

     k = k + 2;
     Form1->ProgressBar1->StepBy(2);
   }
   Form1->Memo2->Lines->Add(ResText);
   Form1->Label3->Caption = Form1->Memo2->Text.Length();
   Form1->Button3->Enabled = true;
   MessageBox(NULL, "����� ������� �����������!", "�����!", MB_OK);
}



//****************************************************************************//
//* ������� ���������� �������������� ������                                 *//
//****************************************************************************//
void FileSave()
{
  if (Form1->RadioButton1->Checked == true)
  {
    Form1->Memo2->Lines->SaveToFile(Dir + "\\encrypted.txt");
    MessageBox(NULL, "���������� ��������� � ���� encrypted.txt � ����� � ����������", "�����!", MB_OK);
    Form1->Button3->Enabled = false;
    Form1->ProgressBar1->Position = 0;
  }

  if (Form1->RadioButton2->Checked == true)
  {
    Form1->Memo2->Lines->SaveToFile(Dir + "\\decrypted.txt");
    MessageBox(NULL, "���������� ��������� � ���� decrypted.txt � ����� � ����������", "�����!", MB_OK);
    Form1->Button3->Enabled = false;
    Form1->ProgressBar1->Position = 0;
  }
}



//****************************************************************************//
//* ���������� ������� �� ������ "������� ����"                              *//
//****************************************************************************//
void __fastcall TForm1::Button1Click(TObject *Sender)
{
   OpenText();
}



//****************************************************************************//
//* ���������� ������� �� ������ "�����"                                     *//
//****************************************************************************//
void __fastcall TForm1::Button2Click(TObject *Sender)
{
  if (Form1->Memo1->Text.Length() == 0)
    MessageBox(NULL, "��� ������ ��� ����������!", "��������� ������!", MB_OK);
  else
  {
    MyText = Form1->Memo1->Text;
    Key = Form1->Edit1->Text;
    if (!CheckKey())
      MessageBox(NULL, "���� ����� ������������� �������!", "��������� ������!", MB_OK);
    else
    {
      Form1->Memo2->Clear();
      if (Form1->RadioButton1->Checked == true)
      {
        CreateR();
        EditText();
        DWORD id = 0;
        HANDLE hThread = CreateThread(NULL, 0, (LPTHREAD_START_ROUTINE)Encrypt, NULL, 0, &id);
      }

      if (Form1->RadioButton2->Checked == true)
      {
        CreateR();
        DWORD id = 0;
        HANDLE hThread = CreateThread(NULL, 0, (LPTHREAD_START_ROUTINE)Decrypt, NULL, 0, &id);
      }
    }
  }
}



//****************************************************************************//
//* ���������� ������� �� ������ "���������"                                 *//
//****************************************************************************//
void __fastcall TForm1::Button3Click(TObject *Sender)
{
  FileSave();
}



//****************************************************************************//
//* ���������� ������� � ���, ��� ������ ���� "���������"                    *//
//****************************************************************************//
void __fastcall TForm1::RadioButton1Click(TObject *Sender)
{
  Form1->Memo2->Clear();
  Form1->Memo3->Clear();
  Form1->Label2->Caption = Form1->Memo1->Text.Length();
  Form1->Label3->Caption = Form1->Memo2->Text.Length();
  Form1->Button3->Enabled = false;
  Form1->ProgressBar1->Position = 0;
}



//****************************************************************************//
//* ���������� ������� � ���, ��� ������ ���� "�����������"                 *//
//****************************************************************************//
void __fastcall TForm1::RadioButton2Click(TObject *Sender)
{
  Form1->Memo2->Clear();
  Form1->Memo3->Clear();
  Form1->Label2->Caption = Form1->Memo1->Text.Length();
  Form1->Label3->Caption = Form1->Memo2->Text.Length();
  Form1->Button3->Enabled = false;
  Form1->ProgressBar1->Position = 0;
}



//****************************************************************************//
//* ���������� ������� �� ������ "� ���������"                               *//
//****************************************************************************//
void __fastcall TForm1::Button4Click(TObject *Sender)
{
  AboutBox->ShowModal();
}



//****************************************************************************//
//* ���������� ������� �� ������ "��������"                                  *//
//****************************************************************************//
void __fastcall TForm1::Button5Click(TObject *Sender)
{
  Form1->Memo1->Clear();
  Form1->Label2->Caption = Form1->Memo1->Text.Length();
}



//****************************************************************************//
//* ���������� ������� �� ������ "����������"                                *//
//****************************************************************************//
void __fastcall TForm1::Button6Click(TObject *Sender)
{
  Form1->Memo1->Text = Form1->Memo2->Text;
  Form1->Memo2->Clear();
  Form1->Label2->Caption = Form1->Memo1->Text.Length();
  Form1->Label3->Caption = Form1->Memo2->Text.Length();
}
//---------------------------------------------------------------------------

