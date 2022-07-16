; 该脚本使用 HM VNISEdit 脚本编辑器向导产生

; 安装程序初始定义常量
!define PRODUCT_NAME "jingziqi"
!define PRODUCT_VERSION "0.6.3"
!define PRODUCT_PUBLISHER "迷惘"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\pssuspend.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

SetCompressor lzma

; ------ MUI 现代界面定义 (1.67 版本以上兼容) ------
!include "MUI.nsh"

; MUI 预定义常量
!define MUI_ABORTWARNING
!define MUI_ICON "axaxx-274kl-001.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"

; 欢迎页面
!insertmacro MUI_PAGE_WELCOME
; 许可协议页面
!insertmacro MUI_PAGE_LICENSE "xuke.txt"
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
OutFile "jingziqi-0.6.3-setup.exe"
InstallDir "$PROGRAMFILES\jingziqi"
InstallDirRegKey HKLM "${PRODUCT_UNINST_KEY}" "UninstallString"
ShowInstDetails show
ShowUnInstDetails show

Section "MainSection" SEC01
  SetOutPath "$INSTDIR"
  SetOverwrite ifnewer
  File "bin\Release\v8_context_snapshot.bin"
  CreateDirectory "$SMPROGRAMS\jingziqi"
  CreateShortCut "$SMPROGRAMS\jingziqi\jingziqi.lnk" "$INSTDIR\jingziqi.exe"
  CreateShortCut "$DESKTOP\jingziqi.lnk" "$INSTDIR\jingziqi.exe"
  File "bin\Release\tupian.zip"
  File "bin\Release\System.Xml.XPath.XDocument.dll"
  File "bin\Release\System.Xml.XPath.dll"
  File "bin\Release\System.Xml.XmlSerializer.dll"
  File "bin\Release\System.Xml.XmlDocument.dll"
  File "bin\Release\System.Xml.XDocument.dll"
  File "bin\Release\System.Xml.ReaderWriter.dll"
  File "bin\Release\System.ValueTuple.dll"
  File "bin\Release\System.Threading.Timer.dll"
  File "bin\Release\System.Threading.ThreadPool.dll"
  File "bin\Release\System.Threading.Thread.dll"
  File "bin\Release\System.Threading.Tasks.Parallel.dll"
  File "bin\Release\System.Threading.Tasks.dll"
  File "bin\Release\System.Threading.Overlapped.dll"
  File "bin\Release\System.Threading.dll"
  File "bin\Release\System.Text.RegularExpressions.dll"
  File "bin\Release\System.Text.Encoding.Extensions.dll"
  File "bin\Release\System.Text.Encoding.dll"
  File "bin\Release\System.Security.SecureString.dll"
  File "bin\Release\System.Security.Principal.dll"
  File "bin\Release\System.Security.Cryptography.X509Certificates.dll"
  File "bin\Release\System.Security.Cryptography.Primitives.dll"
  File "bin\Release\System.Security.Cryptography.Encoding.dll"
  File "bin\Release\System.Security.Cryptography.Csp.dll"
  File "bin\Release\System.Security.Cryptography.Algorithms.dll"
  File "bin\Release\System.Security.Claims.dll"
  File "bin\Release\System.Runtime.Serialization.Xml.dll"
  File "bin\Release\System.Runtime.Serialization.Primitives.dll"
  File "bin\Release\System.Runtime.Serialization.Json.dll"
  File "bin\Release\System.Runtime.Serialization.Formatters.dll"
  File "bin\Release\System.Runtime.Numerics.dll"
  File "bin\Release\System.Runtime.InteropServices.RuntimeInformation.dll"
  File "bin\Release\System.Runtime.InteropServices.dll"
  File "bin\Release\System.Runtime.Handles.dll"
  File "bin\Release\System.Runtime.Extensions.dll"
  File "bin\Release\System.Runtime.dll"
  File "bin\Release\System.Runtime.CompilerServices.VisualC.dll"
  File "bin\Release\System.Resources.Writer.dll"
  File "bin\Release\System.Resources.ResourceManager.dll"
  File "bin\Release\System.Resources.Reader.dll"
  File "bin\Release\System.Reflection.Primitives.dll"
  File "bin\Release\System.Reflection.Extensions.dll"
  File "bin\Release\System.Reflection.dll"
  File "bin\Release\System.ObjectModel.dll"
  File "bin\Release\System.Net.WebSockets.dll"
  File "bin\Release\System.Net.WebSockets.Client.dll"
  File "bin\Release\System.Net.WebHeaderCollection.dll"
  File "bin\Release\System.Net.Sockets.dll"
  File "bin\Release\System.Net.Security.dll"
  File "bin\Release\System.Net.Requests.dll"
  File "bin\Release\System.Net.Primitives.dll"
  File "bin\Release\System.Net.Ping.dll"
  File "bin\Release\System.Net.NetworkInformation.dll"
  File "bin\Release\System.Net.NameResolution.dll"
  File "bin\Release\System.Net.Http.dll"
  File "bin\Release\System.Linq.Queryable.dll"
  File "bin\Release\System.Linq.Parallel.dll"
  File "bin\Release\System.Linq.Expressions.dll"
  File "bin\Release\System.Linq.dll"
  File "bin\Release\System.IO.UnmanagedMemoryStream.dll"
  File "bin\Release\System.IO.Pipes.dll"
  File "bin\Release\System.IO.MemoryMappedFiles.dll"
  File "bin\Release\System.IO.IsolatedStorage.dll"
  File "bin\Release\System.IO.FileSystem.Watcher.dll"
  File "bin\Release\System.IO.FileSystem.Primitives.dll"
  File "bin\Release\System.IO.FileSystem.DriveInfo.dll"
  File "bin\Release\System.IO.FileSystem.dll"
  File "bin\Release\System.IO.dll"
  File "bin\Release\System.IO.Compression.ZipFile.dll"
  File "bin\Release\System.IO.Compression.dll"
  File "bin\Release\System.Globalization.Extensions.dll"
  File "bin\Release\System.Globalization.dll"
  File "bin\Release\System.Globalization.Calendars.dll"
  File "bin\Release\System.Dynamic.Runtime.dll"
  File "bin\Release\System.Drawing.Primitives.dll"
  File "bin\Release\System.Diagnostics.Tracing.dll"
  File "bin\Release\System.Diagnostics.TraceSource.dll"
  File "bin\Release\System.Diagnostics.Tools.dll"
  File "bin\Release\System.Diagnostics.TextWriterTraceListener.dll"
  File "bin\Release\System.Diagnostics.StackTrace.dll"
  File "bin\Release\System.Diagnostics.Process.dll"
  File "bin\Release\System.Diagnostics.FileVersionInfo.dll"
  File "bin\Release\System.Diagnostics.Debug.dll"
  File "bin\Release\System.Diagnostics.Contracts.dll"
  File "bin\Release\System.Data.Common.dll"
  File "bin\Release\System.Console.dll"
  File "bin\Release\System.ComponentModel.TypeConverter.dll"
  File "bin\Release\System.ComponentModel.Primitives.dll"
  File "bin\Release\System.ComponentModel.EventBasedAsync.dll"
  File "bin\Release\System.ComponentModel.dll"
  File "bin\Release\System.Collections.Specialized.dll"
  File "bin\Release\System.Collections.NonGeneric.dll"
  File "bin\Release\System.Collections.dll"
  File "bin\Release\System.Collections.Concurrent.dll"
  File "bin\Release\System.AppContext.dll"
  File "bin\Release\snapshot_blob.bin"
  File "bin\Release\pssuspend.exe"
  File "bin\Release\pepflashplayer.dll"
  File "bin\Release\netstandard.dll"
  File "bin\Release\MySql.Data.dll"
  File "bin\Release\Microsoft.Win32.Primitives.dll"
  File "bin\Release\lishu.ttf"
  File "bin\Release\libcef.dll"
  File "bin\Release\jingziqi.pdb"
  File "bin\Release\jingziqi.exe"
  File "bin\Release\jingziqi.cer"
  File "bin\Release\icudtl.dat"
  File "bin\Release\freevip.pdb"
  File "bin\Release\freevip.exe.config"
  File "bin\Release\freevip.exe"
  File "bin\Release\dutang.txt"
  File "bin\Release\cmd.pdb"
  File "bin\Release\cmd.dll"
  File "bin\Release\chrome_elf.dll"
  File "bin\Release\cert.runtimeconfig.json"
  File "bin\Release\cert.runtimeconfig.dev.json"
  File "bin\Release\cert.pdb"
  File "bin\Release\cert.exe"
  File "bin\Release\cert.dll"
  File "bin\Release\cert.deps.json"
  File "bin\Release\CefSharp.WinForms.dll"
  File "bin\Release\CefSharp.dll"
  File "bin\Release\CefSharp.Core.dll"
  File "bin\Release\CefSharp.BrowserSubprocess.exe"
  File "bin\Release\CefSharp.BrowserSubprocess.Core.dll"
  File "bin\Release\cef.pak"
SectionEnd

Section -AdditionalIcons
  CreateShortCut "$SMPROGRAMS\jingziqi\Uninstall.lnk" "$INSTDIR\uninst.exe"
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\uninst.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\pssuspend.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\pssuspend.exe"
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
  Delete "$INSTDIR\cert.deps.json"
  Delete "$INSTDIR\cert.dll"
  Delete "$INSTDIR\cert.exe"
  Delete "$INSTDIR\cert.pdb"
  Delete "$INSTDIR\cert.runtimeconfig.dev.json"
  Delete "$INSTDIR\cert.runtimeconfig.json"
  Delete "$INSTDIR\chrome_elf.dll"
  Delete "$INSTDIR\cmd.dll"
  Delete "$INSTDIR\cmd.pdb"
  Delete "$INSTDIR\dutang.txt"
  Delete "$INSTDIR\freevip.exe"
  Delete "$INSTDIR\freevip.exe.config"
  Delete "$INSTDIR\freevip.pdb"
  Delete "$INSTDIR\icudtl.dat"
  Delete "$INSTDIR\jingziqi.cer"
  Delete "$INSTDIR\jingziqi.exe"
  Delete "$INSTDIR\jingziqi.pdb"
  Delete "$INSTDIR\libcef.dll"
  Delete "$INSTDIR\lishu.ttf"
  Delete "$INSTDIR\Microsoft.Win32.Primitives.dll"
  Delete "$INSTDIR\MySql.Data.dll"
  Delete "$INSTDIR\netstandard.dll"
  Delete "$INSTDIR\pepflashplayer.dll"
  Delete "$INSTDIR\pssuspend.exe"
  Delete "$INSTDIR\snapshot_blob.bin"
  Delete "$INSTDIR\System.AppContext.dll"
  Delete "$INSTDIR\System.Collections.Concurrent.dll"
  Delete "$INSTDIR\System.Collections.dll"
  Delete "$INSTDIR\System.Collections.NonGeneric.dll"
  Delete "$INSTDIR\System.Collections.Specialized.dll"
  Delete "$INSTDIR\System.ComponentModel.dll"
  Delete "$INSTDIR\System.ComponentModel.EventBasedAsync.dll"
  Delete "$INSTDIR\System.ComponentModel.Primitives.dll"
  Delete "$INSTDIR\System.ComponentModel.TypeConverter.dll"
  Delete "$INSTDIR\System.Console.dll"
  Delete "$INSTDIR\System.Data.Common.dll"
  Delete "$INSTDIR\System.Diagnostics.Contracts.dll"
  Delete "$INSTDIR\System.Diagnostics.Debug.dll"
  Delete "$INSTDIR\System.Diagnostics.FileVersionInfo.dll"
  Delete "$INSTDIR\System.Diagnostics.Process.dll"
  Delete "$INSTDIR\System.Diagnostics.StackTrace.dll"
  Delete "$INSTDIR\System.Diagnostics.TextWriterTraceListener.dll"
  Delete "$INSTDIR\System.Diagnostics.Tools.dll"
  Delete "$INSTDIR\System.Diagnostics.TraceSource.dll"
  Delete "$INSTDIR\System.Diagnostics.Tracing.dll"
  Delete "$INSTDIR\System.Drawing.Primitives.dll"
  Delete "$INSTDIR\System.Dynamic.Runtime.dll"
  Delete "$INSTDIR\System.Globalization.Calendars.dll"
  Delete "$INSTDIR\System.Globalization.dll"
  Delete "$INSTDIR\System.Globalization.Extensions.dll"
  Delete "$INSTDIR\System.IO.Compression.dll"
  Delete "$INSTDIR\System.IO.Compression.ZipFile.dll"
  Delete "$INSTDIR\System.IO.dll"
  Delete "$INSTDIR\System.IO.FileSystem.dll"
  Delete "$INSTDIR\System.IO.FileSystem.DriveInfo.dll"
  Delete "$INSTDIR\System.IO.FileSystem.Primitives.dll"
  Delete "$INSTDIR\System.IO.FileSystem.Watcher.dll"
  Delete "$INSTDIR\System.IO.IsolatedStorage.dll"
  Delete "$INSTDIR\System.IO.MemoryMappedFiles.dll"
  Delete "$INSTDIR\System.IO.Pipes.dll"
  Delete "$INSTDIR\System.IO.UnmanagedMemoryStream.dll"
  Delete "$INSTDIR\System.Linq.dll"
  Delete "$INSTDIR\System.Linq.Expressions.dll"
  Delete "$INSTDIR\System.Linq.Parallel.dll"
  Delete "$INSTDIR\System.Linq.Queryable.dll"
  Delete "$INSTDIR\System.Net.Http.dll"
  Delete "$INSTDIR\System.Net.NameResolution.dll"
  Delete "$INSTDIR\System.Net.NetworkInformation.dll"
  Delete "$INSTDIR\System.Net.Ping.dll"
  Delete "$INSTDIR\System.Net.Primitives.dll"
  Delete "$INSTDIR\System.Net.Requests.dll"
  Delete "$INSTDIR\System.Net.Security.dll"
  Delete "$INSTDIR\System.Net.Sockets.dll"
  Delete "$INSTDIR\System.Net.WebHeaderCollection.dll"
  Delete "$INSTDIR\System.Net.WebSockets.Client.dll"
  Delete "$INSTDIR\System.Net.WebSockets.dll"
  Delete "$INSTDIR\System.ObjectModel.dll"
  Delete "$INSTDIR\System.Reflection.dll"
  Delete "$INSTDIR\System.Reflection.Extensions.dll"
  Delete "$INSTDIR\System.Reflection.Primitives.dll"
  Delete "$INSTDIR\System.Resources.Reader.dll"
  Delete "$INSTDIR\System.Resources.ResourceManager.dll"
  Delete "$INSTDIR\System.Resources.Writer.dll"
  Delete "$INSTDIR\System.Runtime.CompilerServices.VisualC.dll"
  Delete "$INSTDIR\System.Runtime.dll"
  Delete "$INSTDIR\System.Runtime.Extensions.dll"
  Delete "$INSTDIR\System.Runtime.Handles.dll"
  Delete "$INSTDIR\System.Runtime.InteropServices.dll"
  Delete "$INSTDIR\System.Runtime.InteropServices.RuntimeInformation.dll"
  Delete "$INSTDIR\System.Runtime.Numerics.dll"
  Delete "$INSTDIR\System.Runtime.Serialization.Formatters.dll"
  Delete "$INSTDIR\System.Runtime.Serialization.Json.dll"
  Delete "$INSTDIR\System.Runtime.Serialization.Primitives.dll"
  Delete "$INSTDIR\System.Runtime.Serialization.Xml.dll"
  Delete "$INSTDIR\System.Security.Claims.dll"
  Delete "$INSTDIR\System.Security.Cryptography.Algorithms.dll"
  Delete "$INSTDIR\System.Security.Cryptography.Csp.dll"
  Delete "$INSTDIR\System.Security.Cryptography.Encoding.dll"
  Delete "$INSTDIR\System.Security.Cryptography.Primitives.dll"
  Delete "$INSTDIR\System.Security.Cryptography.X509Certificates.dll"
  Delete "$INSTDIR\System.Security.Principal.dll"
  Delete "$INSTDIR\System.Security.SecureString.dll"
  Delete "$INSTDIR\System.Text.Encoding.dll"
  Delete "$INSTDIR\System.Text.Encoding.Extensions.dll"
  Delete "$INSTDIR\System.Text.RegularExpressions.dll"
  Delete "$INSTDIR\System.Threading.dll"
  Delete "$INSTDIR\System.Threading.Overlapped.dll"
  Delete "$INSTDIR\System.Threading.Tasks.dll"
  Delete "$INSTDIR\System.Threading.Tasks.Parallel.dll"
  Delete "$INSTDIR\System.Threading.Thread.dll"
  Delete "$INSTDIR\System.Threading.ThreadPool.dll"
  Delete "$INSTDIR\System.Threading.Timer.dll"
  Delete "$INSTDIR\System.ValueTuple.dll"
  Delete "$INSTDIR\System.Xml.ReaderWriter.dll"
  Delete "$INSTDIR\System.Xml.XDocument.dll"
  Delete "$INSTDIR\System.Xml.XmlDocument.dll"
  Delete "$INSTDIR\System.Xml.XmlSerializer.dll"
  Delete "$INSTDIR\System.Xml.XPath.dll"
  Delete "$INSTDIR\System.Xml.XPath.XDocument.dll"
  Delete "$INSTDIR\tupian.zip"
  Delete "$INSTDIR\v8_context_snapshot.bin"

  Delete "$SMPROGRAMS\jingziqi\Uninstall.lnk"
  Delete "$DESKTOP\jingziqi.lnk"
  Delete "$SMPROGRAMS\jingziqi\jingziqi.lnk"

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
