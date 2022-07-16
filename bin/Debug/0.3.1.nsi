; �ýű�ʹ�� HM VNISEdit �ű��༭���򵼲���

; ��װ�����ʼ���峣��
!define PRODUCT_NAME "������"
!define PRODUCT_VERSION "0.3.1"
!define PRODUCT_PUBLISHER "���"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\pssuspend.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

SetCompressor lzma

; ------ MUI �ִ����涨�� (1.67 �汾���ϼ���) ------
!include "MUI.nsh"

; MUI Ԥ���峣��
!define MUI_ABORTWARNING
!define MUI_ICON "..\..\������3.0.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"

; ��ӭҳ��
!insertmacro MUI_PAGE_WELCOME
; ���Э��ҳ��
!define MUI_LICENSEPAGE_RADIOBUTTONS
!insertmacro MUI_PAGE_LICENSE "..\..\xuke.txt"
; ��װĿ¼ѡ��ҳ��
!insertmacro MUI_PAGE_DIRECTORY
; ��װ����ҳ��
!insertmacro MUI_PAGE_INSTFILES
; ��װ���ҳ��
!define MUI_FINISHPAGE_RUN "$INSTDIR\jingziqi.exe"
!insertmacro MUI_PAGE_FINISH

; ��װж�ع���ҳ��
!insertmacro MUI_UNPAGE_INSTFILES

; ��װ�����������������
!insertmacro MUI_LANGUAGE "SimpChinese"

; ��װԤ�ͷ��ļ�
!insertmacro MUI_RESERVEFILE_INSTALLOPTIONS
; ------ MUI �ִ����涨����� ------

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "..\..\0.3.0.exe"
InstallDir "$PROGRAMFILES\������"
InstallDirRegKey HKLM "${PRODUCT_UNINST_KEY}" "UninstallString"
ShowInstDetails show
ShowUnInstDetails show

Section "MainSection" SEC01
  SetOutPath "$INSTDIR"
  SetOverwrite ifnewer
  File "..\..\..\2333\*.*"
  CreateDirectory "$SMPROGRAMS\������"
  CreateShortCut "$SMPROGRAMS\������\������.lnk" "$INSTDIR\jingziqi.exe"
  CreateShortCut "$DESKTOP\������.lnk" "$INSTDIR\jingziqi.exe"
  File "pssuspend.exe"
  File "cmd.dll"
  File "dutang.txt"
  File "MySql.Data.dll"
  File "���ݿ�����.dll"
  File "jingziqi.exe"
  File "netstandard.dll"
  File "lishu.ttf"
  File "lanpingqingli.exe"
SectionEnd

Section -AdditionalIcons
  CreateShortCut "$SMPROGRAMS\������\Uninstall.lnk" "$INSTDIR\uninst.exe"
SectionEnd

Section
  WriteRegStr HKCU "Software\jingziqi\Settings" "shifoudiyicidakai" "1"
  WriteRegDWORD HKCU "SOFTWARE\Sysinternals\PsSuspend" "EulaAccepted" "1"
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\uninst.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\jingziqi.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\jingziqi.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd

/******************************
 *  �����ǰ�װ�����ж�ز���  *
 ******************************/

Section Uninstall
  Delete "$INSTDIR\uninst.exe"
  Delete "$INSTDIR\jingziqi.exe"
  Delete "$INSTDIR\���ݿ�����.dll"
  Delete "$INSTDIR\MySql.Data.dll"
  Delete "$INSTDIR\dutang.txt"
  Delete "$INSTDIR\cmd.dll"
  Delete "$INSTDIR\pssuspend.exe"
  Delete "$INSTDIR\netstandard.dll"
  Delete "$INSTDIR\lishu.ttf"
  Delete "$INSTDIR\*.*"
  Delete "$INSTDIR\lanpingqingli.exe"
  

  Delete "$SMPROGRAMS\������\Uninstall.lnk"
  Delete "$DESKTOP\������.lnk"
  Delete "$SMPROGRAMS\������\������.lnk"

  RMDir "$SMPROGRAMS\������"

  RMDir "$INSTDIR"

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  SetAutoClose true
SectionEnd

#-- ���� NSIS �ű��༭�������� Function ���α�������� Section ����֮���д���Ա��ⰲװ�������δ��Ԥ֪�����⡣--#

Function un.onInit
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "��ȷʵҪ��ȫ�Ƴ� $(^Name) ���������е������" IDYES +2
  Abort
FunctionEnd

Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) �ѳɹ��ش����ļ�����Ƴ���"
FunctionEnd
