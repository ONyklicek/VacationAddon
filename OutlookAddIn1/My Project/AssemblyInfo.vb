Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security

' Obecné informace o sestavení se řídí přes následující 
' sadu atributů. Změnou hodnot těchto atributů se upraví informace
' přidružené k sestavení.

' Zkontrolujte hodnoty atributů sestavení.

<Assembly: AssemblyTitle("OutlookAddIn1")> 
<Assembly: AssemblyDescription("")> 
<Assembly: AssemblyCompany("")> 
<Assembly: AssemblyProduct("OutlookAddIn1")> 
<Assembly: AssemblyCopyright("Copyright ©  2024")> 
<Assembly: AssemblyTrademark("")> 

' Nastavení atributu ComVisible na hodnotu False udělá typy v tomto sestavení neviditelné 
' pro komponenty modelu COM.  Pokud potřebujete přistupovat k typům tohoto sestavení z 
' modelu COM, nastavte atribut ComVisible daného typu na hodnotu True.
<Assembly: ComVisible(False)>

'Následující GUID se používá pro ID knihovny typů, pokud je tento projekt vystavený pro COM.
<Assembly: Guid("60366dd5-ed5a-404e-8d43-a2a1c5f1459e")> 

' Informace o verzi sestavení se skládá z těchto čtyř hodnot:
'
'      Hlavní verze
'      Dílčí verze 
'      Číslo sestavení
'      Revize
'
' Můžete zadat všechny hodnoty nebo nechat nastavená výchozí čísla sestavení a revize 
' pomocí zástupného znaku * takto:
' <Assembly: AssemblyVersion("1.0.*")> 

<Assembly: AssemblyVersion("1.0.0.0")> 
<Assembly: AssemblyFileVersion("1.0.0.0")> 

Friend Module DesignTimeConstants
    Public Const RibbonTypeSerializer As String = "Microsoft.VisualStudio.Tools.Office.Ribbon.Serialization.RibbonTypeCodeDomSerializer, Microsoft.VisualStudio.Tools.Office.Designer, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Public Const RibbonBaseTypeSerializer As String = "System.ComponentModel.Design.Serialization.TypeCodeDomSerializer, System.Design"
    Public Const RibbonDesigner As String = "Microsoft.VisualStudio.Tools.Office.Ribbon.Design.RibbonDesigner, Microsoft.VisualStudio.Tools.Office.Designer, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
End Module
