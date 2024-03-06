™
HD:\FARRAGAUTUI\TASKMANAGER\wpf_jsoncontrols\wpf_jsoncontrols\App.xaml.cs
	namespace		 	
wpf_jsoncontrols		
 
{

 
public 

partial 
class 
App 
: 
Application *
{ 
} 
} Ì
LD:\FARRAGAUTUI\TASKMANAGER\wpf_jsoncontrols\wpf_jsoncontrols\AssemblyInfo.cs
[ 
assembly 	
:	 

	ThemeInfo 
( &
ResourceDictionaryLocation 
. 
None #
,# $&
ResourceDictionaryLocation 
. 
SourceAssembly -
)

 
]

 Æ
OD:\FARRAGAUTUI\TASKMANAGER\wpf_jsoncontrols\wpf_jsoncontrols\MainWindow.xaml.cs
	namespace 	
wpf_jsoncontrols
 
{ 
public 

partial 
class 

MainWindow #
:$ %
Window& ,
{ 
public 

MainWindow 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
this 
. 
DataContext 
= 
new "
TestViewModel# 0
(0 1!
stkpnlDynamicControls1 F
)F G
;G H
} 	
} 
} ‡
SD:\FARRAGAUTUI\TASKMANAGER\wpf_jsoncontrols\wpf_jsoncontrols\Models\jsoncontrols.cs
	namespace 	
wpf_jsoncontrols
 
. 
Models !
{		 
public

 

class

 
jsoncontrols

 
{ 
public 
int 
ID 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Type 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
Content 
{ 
get  #
;# $
set% (
;( )
}* +
public 
int 
Width 
{ 
get 
; 
set  #
;# $
}% &
public 
int 
row 
{ 
get 
; 
set !
;! "
}# $
public 
int 
column 
{ 
get 
;  
set! $
;$ %
}& '
public 
int 
Height 
{ 
get 
;  
set! $
;$ %
}& '
public 
string 
HorizontalAlignmemt )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
string 
VerticalAlignmemt '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public	 
string 
Path 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
Margin 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
Padding 
{ 
get  #
;# $
set% (
;( )
}* +
public 
int 

ColumnSpan 
{ 
get  #
;# $
set% (
;( )
}* +
public 
int 
RowSpan 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 

Background  
{! "
get# &
;& '
set( +
;+ ,
}- .
}## 
public%% 

class%% 
jsoncontrollist%%  
{&& 
public'' 
List'' 
<'' 
jsoncontrols''  
>''  !
controls''" *
{''+ ,
get''- 0
;''0 1
set''2 5
;''5 6
}''7 8
}(( 
})) é
PD:\FARRAGAUTUI\TASKMANAGER\wpf_jsoncontrols\wpf_jsoncontrols\Models\TestModel.cs
	namespace		 	
wpf_jsoncontrols		
 
.		 
Models		 !
{

 
class 	
	TestModel
 
: 
BindableBase "
{ 
private 

StackPanel 
	_stkPanel $
;$ %
public 

StackPanel 
stkPanel "
{ 	
get 
{ 
return 
	_stkPanel "
;" #
}$ %
set 
{ 
SetProperty 
( 
ref !
	_stkPanel" +
,+ ,
value- 2
)2 3
;3 4
}5 6
} 	
} 
} É
PD:\FARRAGAUTUI\TASKMANAGER\wpf_jsoncontrols\wpf_jsoncontrols\ViewModels\image.cs
	namespace 	
wpf_jsoncontrols
 
. 

ViewModels %
{ 
internal 
class 
image 
{ 
public 
image 
( 
) 
{ 	
}		 	
}

 
} éØ
XD:\FARRAGAUTUI\TASKMANAGER\wpf_jsoncontrols\wpf_jsoncontrols\ViewModels\TestViewModel.cs
	namespace 	
wpf_jsoncontrols
 
. 

ViewModels %
{ 
class 	
TestViewModel
 
: 
BindableBase &
{ 
private 
	TestModel 
	testModel #
;# $
private 
BrushConverter 
bc !
;! "
public 
ICommand 

AddCommand "
{# $
get% (
;( )
private* 1
set2 5
;5 6
}7 8
public 
TestViewModel 
( 

StackPanel '!
stkpnlDynamicControls( =
)= >
{ 	
	testModel 
= 
new 
	TestModel %
(% &
)& '
;' (
	TestModel 
. 
stkPanel 
=  !
stkpnlDynamicControls! 6
;6 7
	AddMethod 
( 
) 
; 
} 	
public   
	TestModel   
	TestModel   "
{!! 	
get"" 
{"" 
return"" 
	testModel"" "
;""" #
}""$ %
set## 
{## 
SetProperty## 
(## 
ref## !
	testModel##" +
,##+ ,
value##- 2
)##2 3
;##3 4
}##5 6
}$$ 	
private%% 
void%% 
	AddMethod%% 
(%% 
)%%  
{&& 	
string'' 
json'' 
='' 
System''  
.''  !
IO''! #
.''# $
File''$ (
.''( )
ReadAllText'') 4
(''4 5
$str''5 C
)''C D
;''D E
List** 
<** 
jsoncontrols** 
>** 
jsoncontrols** +
=**, -
JsonConvert**. 9
.**9 :
DeserializeObject**: K
<**K L
List**L P
<**P Q
jsoncontrols**Q ]
>**] ^
>**^ _
(**_ `
json**` d
)**d e
;**e f
Grid,, 
rootGrid,, 
=,, 
new,, 
Grid,,  $
(,,$ %
),,% &
;,,& '
rootGrid00 
.00 
ColumnDefinitions00 &
.00& '
Add00' *
(00* +
new00+ .
ColumnDefinition00/ ?
(00? @
)00@ A
{00B C
Width00D I
=00J K
new00L O

GridLength00P Z
(00Z [
$num00[ ]
,00] ^
GridUnitType00_ k
.00k l
Pixel00l q
)00q r
}00r s
)00s t
;00t u
rootGrid11 
.11 
ColumnDefinitions11 &
.11& '
Add11' *
(11* +
new11+ .
ColumnDefinition11/ ?
(11? @
)11@ A
{11B C
Width11D I
=11J K
new11L O

GridLength11P Z
(11Z [
$num11[ ^
,11^ _
GridUnitType11` l
.11l m
Pixel11m r
)11r s
}11t u
)11u v
;11v w
rootGrid22 
.22 
ColumnDefinitions22 &
.22& '
Add22' *
(22* +
new22+ .
ColumnDefinition22/ ?
(22? @
)22@ A
{22B C
Width22D I
=22J K
new22L O

GridLength22P Z
(22Z [
$num22[ ^
,22^ _
GridUnitType22` l
.22l m
Pixel22m r
)22r s
}22t u
)22u v
;22v w
rootGrid33 
.33 
ColumnDefinitions33 &
.33& '
Add33' *
(33* +
new33+ .
ColumnDefinition33/ ?
(33? @
)33@ A
{33B C
Width33D I
=33J K
new33L O

GridLength33P Z
(33Z [
$num33[ ^
,33^ _
GridUnitType33` l
.33l m
Pixel33m r
)33r s
}33t u
)33u v
;33v w
rootGrid44 
.44 
ColumnDefinitions44 &
.44& '
Add44' *
(44* +
new44+ .
ColumnDefinition44/ ?
(44? @
)44@ A
{44B C
Width44D I
=44J K
new44L O

GridLength44P Z
(44Z [
$num44[ ^
,44^ _
GridUnitType44` l
.44l m
Pixel44m r
)44r s
}44t u
)44u v
;44v w
rootGrid55 
.55 
ColumnDefinitions55 &
.55& '
Add55' *
(55* +
new55+ .
ColumnDefinition55/ ?
(55? @
)55@ A
{55B C
Width55D I
=55J K
new55L O

GridLength55P Z
(55Z [
$num55[ ^
,55^ _
GridUnitType55` l
.55l m
Pixel55m r
)55r s
}55t u
)55u v
;55v w
rootGrid66 
.66 
ColumnDefinitions66 &
.66& '
Add66' *
(66* +
new66+ .
ColumnDefinition66/ ?
(66? @
)66@ A
{66B C
Width66D I
=66J K
new66L O

GridLength66P Z
(66Z [
$num66[ \
,66\ ]
GridUnitType66^ j
.66j k
Star66k o
)66o p
}66q r
)66r s
;66s t
rootGrid77 
.77 
ColumnDefinitions77 %
.77% &
Add77& )
(77) *
new77* -
ColumnDefinition77. >
(77> ?
)77? @
{77A B
Width77C H
=77I J
new77K N

GridLength77O Y
(77Y Z
$num77Z [
,77[ \
GridUnitType77] i
.77i j
Star77j n
)77n o
}77p q
)77q r
;77r s
rootGrid:: 
.:: 
RowDefinitions:: #
.::# $
Add::$ '
(::' (
new::( +
RowDefinition::, 9
(::9 :
)::: ;
{::< =
Height::> D
=::E F
new::G J

GridLength::K U
(::U V
$num::V W
,::W X
GridUnitType::Y e
.::e f
Auto::f j
)::j k
}::l m
)::m n
;::n o
rootGrid;; 
.;; 
RowDefinitions;; #
.;;# $
Add;;$ '
(;;' (
new;;( +
RowDefinition;;, 9
(;;9 :
);;: ;
{;;< =
Height;;> D
=;;E F
new;;G J

GridLength;;K U
(;;U V
$num;;V W
,;;W X
GridUnitType;;Y e
.;;e f
Auto;;f j
);;j k
};;l m
);;m n
;;;n o
rootGrid<< 
.<< 
RowDefinitions<< #
.<<# $
Add<<$ '
(<<' (
new<<( +
RowDefinition<<, 9
(<<9 :
)<<: ;
{<<< =
Height<<> D
=<<E F
new<<G J

GridLength<<K U
(<<U V
$num<<V W
,<<W X
GridUnitType<<Y e
.<<e f
Auto<<f j
)<<j k
}<<l m
)<<m n
;<<n o
rootGrid== 
.== 
RowDefinitions== #
.==# $
Add==$ '
(==' (
new==( +
RowDefinition==, 9
(==9 :
)==: ;
{==< =
Height==> D
===E F
new==G J

GridLength==K U
(==U V
$num==V W
,==W X
GridUnitType==Y e
.==e f
Auto==f j
)==j k
}==l m
)==m n
;==n o
rootGrid>> 
.>> 
RowDefinitions>> #
.>># $
Add>>$ '
(>>' (
new>>( +
RowDefinition>>, 9
(>>9 :
)>>: ;
{>>< =
Height>>> D
=>>E F
new>>G J

GridLength>>K U
(>>U V
$num>>V W
,>>W X
GridUnitType>>Y e
.>>e f
Auto>>f j
)>>j k
}>>l m
)>>m n
;>>n o
rootGrid?? 
.?? 
RowDefinitions?? #
.??# $
Add??$ '
(??' (
new??( +
RowDefinition??, 9
(??9 :
)??: ;
{??< =
Height??> D
=??E F
new??G J

GridLength??K U
(??U V
$num??V W
,??W X
GridUnitType??Y e
.??e f
Auto??f j
)??j k
}??l m
)??m n
;??n o
rootGrid@@ 
.@@ 
RowDefinitions@@ #
.@@# $
Add@@$ '
(@@' (
new@@( +
RowDefinition@@, 9
(@@9 :
)@@: ;
{@@< =
Height@@> D
=@@E F
new@@G J

GridLength@@K U
(@@U V
$num@@V W
,@@W X
GridUnitType@@Y e
.@@e f
Auto@@f j
)@@j k
}@@l m
)@@m n
;@@n o
rootGridAA 
.AA 
RowDefinitionsAA #
.AA# $
AddAA$ '
(AA' (
newAA( +
RowDefinitionAA, 9
(AA9 :
)AA: ;
{AA< =
HeightAA> D
=AAE F
newAAG J

GridLengthAAK U
(AAU V
$numAAV W
,AAW X
GridUnitTypeAAY e
.AAe f
AutoAAf j
)AAj k
}AAl m
)AAm n
;AAn o
rootGridBB 
.BB 
RowDefinitionsBB #
.BB# $
AddBB$ '
(BB' (
newBB( +
RowDefinitionBB, 9
(BB9 :
)BB: ;
{BB< =
HeightBB> D
=BBE F
newBBG J

GridLengthBBK U
(BBU V
$numBBV W
,BBW X
GridUnitTypeBBY e
.BBe f
AutoBBf j
)BBj k
}BBl m
)BBm n
;BBn o
rootGridCC 
.CC 
RowDefinitionsCC #
.CC# $
AddCC$ '
(CC' (
newCC( +
RowDefinitionCC, 9
(CC9 :
)CC: ;
{CC< =
HeightCC> D
=CCE F
newCCG J

GridLengthCCK U
(CCU V
$numCCV W
,CCW X
GridUnitTypeCCY e
.CCe f
AutoCCf j
)CCj k
}CCl m
)CCm n
;CCn o
rootGridDD 
.DD 
RowDefinitionsDD #
.DD# $
AddDD$ '
(DD' (
newDD( +
RowDefinitionDD, 9
(DD9 :
)DD: ;
{DD< =
HeightDD> D
=DDE F
newDDG J

GridLengthDDK U
(DDU V
$numDDV W
,DDW X
GridUnitTypeDDY e
.DDe f
AutoDDf j
)DDj k
}DDl m
)DDm n
;DDn o
rootGridEE 
.EE 
RowDefinitionsEE #
.EE# $
AddEE$ '
(EE' (
newEE( +
RowDefinitionEE, 9
(EE9 :
)EE: ;
{EE< =
HeightEE> D
=EEE F
newEEG J

GridLengthEEK U
(EEU V
$numEEV W
,EEW X
GridUnitTypeEEY e
.EEe f
AutoEEf j
)EEj k
}EEl m
)EEm n
;EEn o
rootGridFF 
.FF 
RowDefinitionsFF #
.FF# $
AddFF$ '
(FF' (
newFF( +
RowDefinitionFF, 9
(FF9 :
)FF: ;
{FF< =
HeightFF> D
=FFE F
newFFG J

GridLengthFFK U
(FFU V
$numFFV W
,FFW X
GridUnitTypeFFY e
.FFe f
StarFFf j
)FFj k
}FFl m
)FFm n
;FFn o
rootGridGG 
.GG 
RowDefinitionsGG #
.GG# $
AddGG$ '
(GG' (
newGG( +
RowDefinitionGG, 9
(GG9 :
)GG: ;
{GG< =
HeightGG> D
=GGE F
newGGG J

GridLengthGGK U
(GGU V
$numGGV W
,GGW X
GridUnitTypeGGY e
.GGe f
AutoGGf j
)GGj k
}GGl m
)GGm n
;GGn o
rootGridHH 
.HH 
RowDefinitionsHH #
.HH# $
AddHH$ '
(HH' (
newHH( +
RowDefinitionHH, 9
(HH9 :
)HH: ;
{HH< =
HeightHH> D
=HHE F
newHHG J

GridLengthHHK U
(HHU V
$numHHV W
,HHW X
GridUnitTypeHHY e
.HHe f
StarHHf j
)HHj k
}HHl m
)HHm n
;HHn o
forKK 
(KK 
intKK 
iKK 
=KK 
$numKK 
;KK 
iKK 
<KK 
jsoncontrolsKK (
.KK( )
CountKK) .
;KK. /
iKK/ 0
++KK0 2
)KK2 3
{LL 
ifMM 
(MM 
jsoncontrolsMM  
[MM  !
iMM! "
]MM" #
.MM# $
TypeMM$ (
==MM) +
$strMM, 6
)MM6 7
{NN 
CheckBoxOO 
cboxOO !
=OO" #
newOO$ '
CheckBoxOO( 0
(OO0 1
)OO1 2
;OO2 3
cboxPP 
.PP 
ContentPP  
=PP! "
jsoncontrolsPP# /
[PP/ 0
iPP0 1
]PP1 2
.PP2 3
ContentPP3 :
;PP: ;
cboxQQ 
.QQ 
MarginQQ 
=QQ  !
newQQ" %
	ThicknessQQ& /
(QQ/ 0
$numQQ0 1
,QQ1 2
$numQQ3 4
,QQ4 5
$numQQ6 8
,QQ8 9
$numQQ: ;
)QQ; <
;QQ< =
GridRR 
.RR 
	SetColumnRR "
(RR" #
cboxRR# '
,RR' (
jsoncontrolsRR) 5
[RR5 6
iRR6 7
]RR7 8
.RR8 9
columnRR9 ?
)RR? @
;RR@ A
GridSS 
.SS 
SetColumnSpanSS &
(SS& '
cboxSS' +
,SS+ ,
jsoncontrolsSS- 9
[SS9 :
iSS: ;
]SS; <
.SS< =

ColumnSpanSS= G
)SSG H
;SSH I
GridTT 
.TT 
SetRowTT 
(TT  
cboxTT  $
,TT$ %
jsoncontrolsTT& 2
[TT2 3
iTT3 4
]TT4 5
.TT5 6
rowTT6 9
)TT9 :
;TT: ;
rootGridUU 
.UU 
ChildrenUU %
.UU% &
AddUU& )
(UU) *
cboxUU* .
)UU. /
;UU/ 0
}VV 
elseWW 
ifWW 
(WW 
jsoncontrolsWW %
[WW% &
iWW& '
]WW' (
.WW( )
TypeWW) -
==WW. 0
$strWW1 :
)WW: ;
{XX 
TextBoxYY 
tbYY 
=YY  
newYY! $
TextBoxYY% ,
(YY, -
)YY- .
;YY. /
tbZZ 
.ZZ 
TextZZ 
=ZZ 
jsoncontrolsZZ *
[ZZ* +
iZZ+ ,
]ZZ, -
.ZZ- .
ContentZZ. 5
;ZZ5 6
Grid\\ 
.\\ 
	SetColumn\\ "
(\\" #
tb\\# %
,\\% &
jsoncontrols\\' 3
[\\3 4
i\\4 5
]\\5 6
.\\6 7
column\\7 =
)\\= >
;\\> ?
Grid]] 
.]] 
SetRow]] 
(]]  
tb]]  "
,]]" #
jsoncontrols]]$ 0
[]]0 1
i]]1 2
]]]2 3
.]]3 4
row]]4 7
)]]7 8
;]]8 9
tb^^ 
.^^ 
Margin^^ 
=^^ 
new^^  #
	Thickness^^$ -
(^^- .
$num^^. 0
,^^0 1
$num^^2 3
,^^3 4
$num^^5 6
,^^6 7
$num^^8 9
)^^9 :
;^^: ;
tbbb 
.bb 

Backgroundbb  
=bb! "
(bb# $
SolidColorBrushbb$ 3
)bb3 4
newbb4 7
BrushConverterbb8 F
(bbF G
)bbG H
.bbH I
ConvertFromStringbbI Z
(bbZ [
$strbb[ d
)bbd e
;bbe f
Griddd 
.dd 
SetColumnSpandd &
(dd& '
tbdd' )
,dd) *
jsoncontrolsdd+ 7
[dd7 8
idd8 9
]dd9 :
.dd: ;

ColumnSpandd; E
)ddE F
;ddF G
rootGridhh 
.hh 
Childrenhh %
.hh% &
Addhh& )
(hh) *
tbhh* ,
)hh, -
;hh- .
}jj 
elsekk 
ifkk 
(kk 
jsoncontrolskk %
[kk% &
ikk& '
]kk' (
.kk( )
Typekk) -
==kk. 0
$strkk1 9
)kk9 :
{ll 
Buttonmm 
btnmm 
=mm  
newmm! $
Buttonmm% +
(mm+ ,
)mm, -
;mm- .
btnnn 
.nn 
Contentnn 
=nn  !
jsoncontrolsnn" .
[nn. /
inn/ 0
]nn0 1
.nn1 2
Contentnn2 9
;nn9 :
btnoo 
.oo 
Widthoo 
=oo 
jsoncontrolsoo  ,
[oo, -
ioo- .
]oo. /
.oo/ 0
Widthoo0 5
;oo5 6
btnpp 
.pp 
Heightpp 
=pp  
jsoncontrolspp! -
[pp- .
ipp. /
]pp/ 0
.pp0 1
Heightpp1 7
;pp7 8
Gridss 
.ss 
	SetColumnss "
(ss" #
btnss# &
,ss& '
jsoncontrolsss( 4
[ss4 5
iss5 6
]ss6 7
.ss7 8
columnss8 >
)ss> ?
;ss? @
Gridtt 
.tt 
SetRowtt 
(tt  
btntt  #
,tt# $
jsoncontrolstt% 1
[tt1 2
itt2 3
]tt3 4
.tt4 5
rowtt5 8
)tt8 9
;tt9 :
btnuu 
.uu 
Marginuu 
=uu  
newuu! $
	Thicknessuu% .
(uu. /
$numuu/ 0
,uu0 1
$numuu2 4
,uu4 5
$numuu6 7
,uu7 8
$numuu9 ;
)uu; <
;uu< =
btnvv 
.vv 

Backgroundvv !
=vv" #
(vv$ %
SolidColorBrushvv% 4
)vv4 5
newvv5 8
BrushConvertervv9 G
(vvG H
)vvH I
.vvI J
ConvertFromStringvvJ [
(vv[ \
$strvv\ e
)vve f
;vvf g
btnyy 
.yy 
Paddingyy 
=yy  !
newyy" %
	Thicknessyy& /
(yy/ 0
$numyy0 1
,yy1 2
$numyy3 4
,yy4 5
$numyy6 7
,yy7 8
$numyy9 :
)yy: ;
;yy; <
Gridzz 
.zz 
SetColumnSpanzz &
(zz& '
btnzz' *
,zz* +
jsoncontrolszz, 8
[zz8 9
izz9 :
]zz: ;
.zz; <

ColumnSpanzz< F
)zzF G
;zzG H
rootGrid|| 
.|| 
Children|| %
.||% &
Add||& )
(||) *
btn||* -
)||- .
;||. /
}}} 
else
ÄÄ 
if
ÄÄ 
(
ÄÄ 
jsoncontrols
ÄÄ %
[
ÄÄ% &
i
ÄÄ& '
]
ÄÄ' (
.
ÄÄ( )
Type
ÄÄ) -
==
ÄÄ. 0
$str
ÄÄ1 8
)
ÄÄ8 9
{
ÅÅ 
System
ÇÇ 
.
ÇÇ 
Windows
ÇÇ "
.
ÇÇ" #
Controls
ÇÇ# +
.
ÇÇ+ ,
Image
ÇÇ, 1
img
ÇÇ2 5
=
ÇÇ6 7
new
ÇÇ8 ;
System
ÇÇ< B
.
ÇÇB C
Windows
ÇÇC J
.
ÇÇJ K
Controls
ÇÇK S
.
ÇÇS T
Image
ÇÇT Y
(
ÇÇY Z
)
ÇÇZ [
;
ÇÇ[ \
Uri
ÉÉ 
imageUri
ÉÉ  
=
ÉÉ! "
new
ÉÉ# &
Uri
ÉÉ' *
(
ÉÉ* +
jsoncontrols
ÉÉ+ 7
[
ÉÉ7 8
i
ÉÉ8 9
]
ÉÉ9 :
.
ÉÉ: ;
Path
ÉÉ; ?
,
ÉÉ? @
UriKind
ÉÉA H
.
ÉÉH I
Relative
ÉÉI Q
)
ÉÉQ R
;
ÉÉR S
BitmapImage
ÑÑ 
imageBitmap
ÑÑ  +
=
ÑÑ, -
new
ÑÑ. 1
BitmapImage
ÑÑ2 =
(
ÑÑ= >
imageUri
ÑÑ> F
)
ÑÑF G
;
ÑÑG H
img
ÜÜ 
.
ÜÜ 
Source
ÜÜ 
=
ÜÜ  
imageBitmap
ÜÜ! ,
;
ÜÜ, -
img
áá 
.
áá 
Width
áá 
=
áá 
jsoncontrols
áá  ,
[
áá, -
i
áá- .
]
áá. /
.
áá/ 0
Width
áá0 5
;
áá5 6
img
àà 
.
àà 
Height
àà 
=
àà  
jsoncontrols
àà! -
[
àà- .
i
àà. /
]
àà/ 0
.
àà0 1
Height
àà1 7
;
àà7 8
img
ââ 
.
ââ 
Margin
ââ 
=
ââ  
new
ââ! $
	Thickness
ââ% .
(
ââ. /
$num
ââ/ 0
,
ââ0 1
$num
ââ2 3
,
ââ3 4
$num
ââ5 6
,
ââ6 7
$num
ââ8 9
)
ââ9 :
;
ââ: ;
img
ää 
.
ää !
HorizontalAlignment
ää +
=
ää, -!
HorizontalAlignment
ää. A
.
ääA B
Left
ääB F
;
ääF G
Grid
ãã 
.
ãã 
	SetColumn
ãã "
(
ãã" #
img
ãã# &
,
ãã& '
jsoncontrols
ãã( 4
[
ãã4 5
i
ãã5 6
]
ãã6 7
.
ãã7 8
column
ãã8 >
)
ãã> ?
;
ãã? @
Grid
åå 
.
åå 
SetRow
åå 
(
åå  
img
åå  #
,
åå# $
jsoncontrols
åå% 1
[
åå1 2
i
åå2 3
]
åå3 4
.
åå4 5
row
åå5 8
)
åå8 9
;
åå9 :
rootGrid
çç 
.
çç 
Children
çç %
.
çç% &
Add
çç& )
(
çç) *
img
çç* -
)
çç- .
;
çç. /
}
èè 
}
ëë 
	TestModel
íí 
.
íí 
stkPanel
íí 
.
íí 
Children
íí '
.
íí' (
Add
íí( +
(
íí+ ,
rootGrid
íí, 4
)
íí4 5
;
íí5 6
}
ìì 	
}
ïï 
}ññ 