; �ýű�ʹ�� HM VNISEdit �ű��༭���򵼲���

; ��װ�����ʼ���峣��
!define PRODUCT_NAME "������"
!define PRODUCT_VERSION "0.5.0"
!define PRODUCT_PUBLISHER "���"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\update.exe"
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
!define MUI_LICENSEPAGE_CHECKBOX
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
OutFile "jingziqi-setup-v0.5.0.exe"
InstallDir "$PROGRAMFILES\jingziqi"
InstallDirRegKey HKLM "${PRODUCT_UNINST_KEY}" "UninstallString"
ShowInstDetails show
ShowUnInstDetails show

Section "MainSection" SEC01
  SetOutPath "$INSTDIR"
  SetOverwrite ifnewer
  File "2333\*.*"
  CreateDirectory "$SMPROGRAMS\jingziqi"
  CreateShortCut "$SMPROGRAMS\jingziqi\������.lnk" "$INSTDIR\jingziqi.exe"
  CreateShortCut "$DESKTOP\������.lnk" "$INSTDIR\jingziqi.exe"
  File "���ݿ�����.dll"
  File "v8_context_snapshot.bin"
  File "update.exe"
  File "snapshot_blob.bin"
  File "Renci.SshNet.dll"
  File "pssuspend.exe"
  File "pepflashplayer.dll"
  File "netstandard.dll"
  File "MySql.Data.dll"
  File "Microsoft.Win32.Primitives.dll"
  File "lishu.ttf"
  File "libcef.dll"
  File "jingziqi.pdb"
  File "jingziqi.exe.config"
  File "jingziqi.exe"
  File "icudtl.dat"
  File "freevip.pdb"
  File "freevip.exe.config"
  File "freevip.exe"
  File "dutang.txt"
  File "cmd.pdb"
  File "cmd.dll"
  File "chrome_elf.dll"
  File "CefSharp.WinForms.dll"
  File "CefSharp.dll"
  File "CefSharp.Core.dll"
  File "CefSharp.BrowserSubprocess.exe"
  File "CefSharp.BrowserSubprocess.Core.dll"
  File "cef.pak"
SectionEnd

Section -AdditionalIcons
  CreateShortCut "$SMPROGRAMS\jingziqi\Uninstall.lnk" "$INSTDIR\uninst.exe"
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\uninst.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\update.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\update.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd

/******************************
 *  �����ǰ�װ�����ж�ز���  *
 ******************************/

Section Uninstall
  Delete "$INSTDIR\uninst.exe"
  Delete "$INSTDIR\cef.pak"
  Delete "$INSTDIR\CefSharp.BrowserSubprocess.Core.dll"
  Delete "$INSTDIR\CefSharp.BrowserSubprocess.exe"
  Delete "$INSTDIR\CefSharp.Core.dll"
  Delete "$INSTDIR\CefSharp.dll"
  Delete "$INSTDIR\CefSharp.WinForms.dll"
  Delete "$INSTDIR\chrome_elf.dll"
  Delete "$INSTDIR\cmd.dll"
  Delete "$INSTDIR\cmd.pdb"
  Delete "$INSTDIR\dutang.txt"
  Delete "$INSTDIR\freevip.exe"
  Delete "$INSTDIR\freevip.exe.config"
  Delete "$INSTDIR\freevip.pdb"
  Delete "$INSTDIR\icudtl.dat"
  Delete "$INSTDIR\jingziqi.exe"
  Delete "$INSTDIR\jingziqi.exe.config"
  Delete "$INSTDIR\jingziqi.pdb"
  Delete "$INSTDIR\libcef.dll"
  Delete "$INSTDIR\lishu.ttf"
  Delete "$INSTDIR\Microsoft.Win32.Primitives.dll"
  Delete "$INSTDIR\MySql.Data.dll"
  Delete "$INSTDIR\netstandard.dll"
  Delete "$INSTDIR\pepflashplayer.dll"
  Delete "$INSTDIR\pssuspend.exe"
  Delete "$INSTDIR\Renci.SshNet.dll"
  Delete "$INSTDIR\snapshot_blob.bin"
  Delete "$INSTDIR\update.exe"
  Delete "$INSTDIR\v8_context_snapshot.bin"
  Delete "$INSTDIR\���ݿ�����.dll"
  Delete "$INSTDIR\*.*"

  Delete "$SMPROGRAMS\jingziqi\Uninstall.lnk"
  Delete "$DESKTOP\������.lnk"
  Delete "$SMPROGRAMS\jingziqi\������.lnk"

  RMDir "$SMPROGRAMS\jingziqi"

  RMDir "$INSTDIR"

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  SetAutoClose true
SectionEnd

Section
  WriteRegStr HKCU "Software\jingziqi\Settings" "shifoudiyicidakai" "1"
  WriteRegDWORD HKCU "SOFTWARE\Sysinternals\PsSuspend" "EulaAccepted" "1"
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

Var UNINSTALL_PROG
Var OLD_VER
Var OLD_PATH


Function .onInit
  ClearErrors
  ReadRegStr $UNINSTALL_PROG ${PRODUCT_UNINST_ROOT_KEY} ${PRODUCT_UNINST_KEY} "UninstallString"
  IfErrors  done

  ReadRegStr $OLD_VER ${PRODUCT_UNINST_ROOT_KEY} ${PRODUCT_UNINST_KEY} "DisplayVersion"
  MessageBox MB_YESNOCANCEL|MB_ICONQUESTION \
    "��⵽�����Ѿ���װ�� ${PRODUCT_NAME} $OLD_VER��\
    $\n$\n�Ƿ���ж���Ѱ�װ�İ汾��" \
      /SD IDYES \
      IDYES uninstall \
      IDNO done
  Abort

uninstall:
  StrCpy $OLD_PATH $UNINSTALL_PROG -10


  ExecWait '"$UNINSTALL_PROG" /S _?=$OLD_PATH' $0
  DetailPrint "uninst.exe returned $0"
  Delete "$UNINSTALL_PROG"
  RMDir $OLD_PATH


done:
FunctionEnd

