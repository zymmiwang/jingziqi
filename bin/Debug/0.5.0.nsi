; 该脚本使用 HM VNISEdit 脚本编辑器向导产生

; 安装程序初始定义常量
!define PRODUCT_NAME "井字棋"
!define PRODUCT_VERSION "0.5.0"
!define PRODUCT_PUBLISHER "迷惘"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\update.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

SetCompressor lzma

; ------ MUI 现代界面定义 (1.67 版本以上兼容) ------
!include "MUI.nsh"

; MUI 预定义常量
!define MUI_ABORTWARNING
!define MUI_ICON "..\..\井字棋3.0.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"

; 欢迎页面
!insertmacro MUI_PAGE_WELCOME
; 许可协议页面
!define MUI_LICENSEPAGE_CHECKBOX
!insertmacro MUI_PAGE_LICENSE "..\..\xuke.txt"
; 安装目录选择页面
!insertmacro MUI_PAGE_DIRECTORY
; 安装过程页面
!insertmacro MUI_PAGE_INSTFILES
; 安装完成页面
!define MUI_FINISHPAGE_RUN "$INSTDIR\jingziqi.exe"
!insertmacro MUI_PAGE_FINISH

; 安装卸载过程页面
!insertmacro MUI_UNPAGE_INSTFILES

; 安装界面包含的语言设置
!insertmacro MUI_LANGUAGE "SimpChinese"

; 安装预释放文件
!insertmacro MUI_RESERVEFILE_INSTALLOPTIONS
; ------ MUI 现代界面定义结束 ------

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
  CreateShortCut "$SMPROGRAMS\jingziqi\井字棋.lnk" "$INSTDIR\jingziqi.exe"
  CreateShortCut "$DESKTOP\井字棋.lnk" "$INSTDIR\jingziqi.exe"
  File "数据库连接.dll"
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
 *  以下是安装程序的卸载部分  *
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
  Delete "$INSTDIR\数据库连接.dll"
  Delete "$INSTDIR\*.*"

  Delete "$SMPROGRAMS\jingziqi\Uninstall.lnk"
  Delete "$DESKTOP\井字棋.lnk"
  Delete "$SMPROGRAMS\jingziqi\井字棋.lnk"

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

#-- 根据 NSIS 脚本编辑规则，所有 Function 区段必须放置在 Section 区段之后编写，以避免安装程序出现未可预知的问题。--#

Function un.onInit
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "您确实要完全移除 $(^Name) ，及其所有的组件？" IDYES +2
  Abort
FunctionEnd

Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) 已成功地从您的计算机移除。"
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
    "检测到本机已经安装了 ${PRODUCT_NAME} $OLD_VER。\
    $\n$\n是否先卸载已安装的版本？" \
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

