(**
# Histograms

[![Binder](https://plotly.net/img/badge-binder.svg)](https://mybinder.org/v2/gh/plotly/Plotly.NET/gh-pages?filepath=04_0_histograms.ipynb)&emsp;
[![Script](https://plotly.net/img/badge-script.svg)](https://plotly.net/04_0_histograms.fsx)&emsp;
[![Notebook](https://plotly.net/img/badge-notebook.svg)](https://plotly.net/04_0_histograms.ipynb)

**Summary:** This example shows how to create a one-dimensional histogram of a data samples in F#.

let's first create some data for the purpose of creating example charts:

*)
open Plotly.NET 

let rnd = System.Random()
let x = [for i=0 to 500 do yield rnd.NextDouble() ]
(**
A histogram consisting of rectangles whose area is proportional to the frequency of a variable and whose width is equal to the class interval.
The histogram chart represents the distribution of numerical data and can be created using the `Chart.Histogram` function:.

*)
let histo1 =
    x
    |> Chart.Histogram
    |> Chart.withSize(500.,500.)(* output: 
<div id="531a67d9-741c-427a-8e99-f0877d9cae54"><!-- Plotly chart will be drawn inside this DIV --></div>
<script type="text/javascript">

            var renderPlotly_531a67d9741c427a8e99f0877d9cae54 = function() {
            var fsharpPlotlyRequire = requirejs.config({context:'fsharp-plotly',paths:{plotly:'https://cdn.plot.ly/plotly-2.6.3.min'}}) || require;
            fsharpPlotlyRequire(['plotly'], function(Plotly) {

            var data = [{"type":"histogram","x":[0.5824740002222546,0.8737384659277898,0.0588278693586074,0.10934903122448636,0.20385966865350325,0.6444873281182539,0.23532772103665411,0.7720236650811415,0.7259129852569595,0.20261655862102534,0.11384939100354907,0.8423216480085318,0.0021155882077220634,0.755078370676707,0.05462441689830899,0.8859545049661431,0.8548096313688247,0.5467160230812184,0.627728466997206,0.8524740262792688,0.4206371642558927,0.5632211685960016,0.11982077599022178,0.7691925528062731,0.998935956634017,0.09687586405769955,0.9656042777370594,0.40330780926149123,0.7495031954821249,0.49786863282374627,0.4281482304144292,0.46257934567862025,0.19786201873598863,0.41887856544067537,0.5653929300414943,0.8898069432199893,0.4455152124112016,0.28220653580291455,0.3879214854854409,0.2457058256561233,0.6225090039055978,0.5086782018356796,0.4326245783427789,0.2715319476000724,0.7205680552618556,0.6548098780448308,0.7126509833333066,0.35762644913054065,0.6209938474464805,0.14766634751223695,0.2919507983052695,0.5731209628363644,0.5481656864662117,0.2675451718313179,0.11400182384522861,0.4240853034484192,0.9003503933645048,0.5350472655816795,0.12706616647557767,0.4843129937839866,0.2922937863341768,0.92762373597848,0.3975606464126382,0.9955101673016162,0.9242888704913095,0.8475607517235471,0.5850173167487452,0.381185211554533,0.17453024903503866,0.7789668981017548,0.4445653074054676,0.6799621175180576,0.5205997209909042,0.16857359531024896,0.13002833022539828,0.9518291363920203,0.35390838748465425,0.7054908074790534,0.8015640777517975,0.5690426703425678,0.6287484531569784,0.3116730301537948,0.6087631221795547,0.13195997724577502,0.5911384062122478,0.3522427866986987,0.7107780229491021,0.7142760035012051,0.354143656691022,0.8007212261033662,0.36753965251005394,0.5424745266867154,0.5307132934048078,0.3794300434911626,0.16193790062528524,0.1276172466045734,0.9704975973905053,0.5327427822714313,0.0050521573197114256,0.8155980804387923,0.03561314425503026,0.3904605943520639,0.37051053516472976,0.1144564408238482,0.5721223132854619,0.006172427558425175,0.5485529141857495,0.17249125390969078,0.7482696921015597,0.844278309292249,0.9371802463969817,0.02247279106702671,0.3786964227543904,0.4215663659131741,0.08031396590968864,0.33427042724452893,0.21806528911771272,0.465699689171556,0.1255934515784154,0.49441145293997035,0.9255144429707309,0.6710533285668789,0.06214108516604333,0.43542116971993294,0.8622972645022133,0.07507744061560095,0.9146828299990586,0.3444520698698105,0.5828960727121014,0.12421657648061701,0.6689821167284601,0.8328570763163812,0.5068355894625521,0.3111297026445634,0.8098239902073204,0.7406544923832479,0.27574971765332146,0.40511308130756707,0.9476492921874825,0.07885957073653005,0.7342676502852279,0.13285266045714184,0.8200758223405369,0.18907002886573188,0.38545499093761093,0.5432016284776584,0.12223167813458458,0.7435470604249028,0.798792942166283,0.39648516131410294,0.5617370563713429,0.9619718395861828,0.33072983082653085,0.6707670117170736,0.48568252175306903,0.514792193427897,0.6857252983868865,0.9251935734559652,0.11011951153037813,0.000185285820408998,0.02238094670618762,0.32945085621693904,0.9677116391380199,0.09814362182631375,0.06722693319242867,0.16505331968246462,0.04914883081501542,0.6151402089794199,0.9026345801446453,0.7004488614823235,0.20847562601734415,0.6689428242267961,0.05986072808189358,0.14724728558091904,0.23110968052093672,0.6888245675710556,0.4565568088611506,0.15973290666669693,0.9185809066207912,0.46247251848935456,0.40125822016021984,0.9981130583850023,0.7522953407975478,0.9362400155744508,0.6142276039039481,0.44065913874245455,0.9478135447726985,0.6526765315819283,0.14505011290474734,0.49247744033011276,0.5428659616329711,0.675021005286244,0.9707086730300942,0.40178041085347416,0.29750908626208994,0.00787167154546331,0.4032948511617964,0.10289123101901143,0.6624689120600425,0.09959999741880265,0.2888896348726304,0.30115841645033414,0.3324549578481901,0.9105789833962568,0.09422382208259983,0.5686358999924099,0.5659526521201881,0.9790198291578884,0.08215243351489276,0.1719131443131433,0.8952372025324232,0.13722795613882088,0.4128255580967759,0.08285533044463833,0.835802745741202,0.5137648850023518,0.8036876352270393,0.5396157927572858,0.36840570867438727,0.8867608842178947,0.2237683604740891,0.49826077285581205,0.752764892915933,0.14411904503272965,0.033032345863595935,0.5701805788671317,0.878805752924769,0.8162113831495633,0.6109354624820694,0.8021283864177823,0.26833484191040935,0.4565829323922429,0.06596150030969794,0.23880178823377174,0.98099311470335,0.2262557046220821,0.5782591449404221,0.4405116018352244,0.38931150087307775,0.8410528015276499,0.730080431660492,0.7936308272391316,0.91933111595864,0.8432297996421502,0.7421402206159213,0.11436634472872997,0.02592897062150923,0.6122841865821584,0.38375583118335066,0.6219519847185315,0.7305639030658689,0.9941522475667748,0.47671793024505515,0.05417058055269974,0.12735507245971522,0.9405124841716368,0.3849602637703793,0.02900493260618997,0.9735664602343591,0.8004437630789772,0.4215060316893061,0.1620720065256981,0.218302005245672,0.48076280106677305,0.08863250068933715,0.20362271751747818,0.2721413238529323,0.6005720356469163,0.5503526800198766,0.761086658367865,0.1636541238181084,0.44109244081403964,0.8956680714904016,0.5354312242639363,0.438216338954593,0.07097061747590727,0.4621693743733172,0.07786906348632072,0.9158870383827635,0.8161186092818403,0.5531993582536802,0.9005494802811599,0.43328424418753575,0.8404948450528124,0.7058306388975883,0.4948000875073739,0.2882339910272995,0.6173978532869987,0.8889116516511412,0.19036210032018774,0.3763165444400408,0.6058604809281495,0.39940277380845624,0.7820249144876655,0.4196110812546353,0.31766527220719676,0.3627234367924135,0.652587152784519,0.38243358076456857,0.9578209259235005,0.551328329800854,0.4188768884704417,0.4023550671459558,0.6753302867309814,0.8786315460228012,0.5391444667852898,0.0595788032313892,0.6130509351563773,0.4481258226009286,0.4331115487752315,0.3611519068587372,0.7951105759013829,0.8023722359541859,0.7754108092730346,0.5672704292247366,0.37716479756393795,0.6959812377692995,0.37283558420211116,0.7649453610200766,0.299323456379297,0.3895123154299057,0.9617693458075952,0.014474056101797528,0.0897513876142505,0.5046449184078176,0.049892469774025505,0.2924763218583427,0.9386388463886456,0.3067646193791608,0.6737190636876972,0.7754827857162578,0.2110750765765217,0.7911591343982449,0.7024019107308271,0.37559858104101307,0.3919112348744691,0.10725657178051129,0.8188874996611334,0.4201767892434374,0.02630570977615687,0.09036316499749175,0.2988706166711751,0.5831301801807907,0.9711627072150053,0.34407604660841673,0.5917161171269885,0.5630729427191772,0.05967230466412743,0.5573854430573942,0.048609719788923256,0.5127945976277499,0.3630124981062395,0.7801375559687033,0.12586567469233523,0.5975193135559886,0.08567535243190838,0.8647620914896287,0.45247162000687957,0.5475645238587298,0.4733917304825088,0.5729019132698887,0.3115151808622597,0.06109441382936853,0.9922141189099621,0.5340292020599386,0.11532022020485,0.00946764081374607,0.9436633695341194,0.14548213983475278,0.12687625325752783,0.7533151373696888,0.008743630656919299,0.7250894619435289,0.2558838496583078,0.20982009297171278,0.8348762924331109,0.8018237944953561,0.4082774590028496,0.022965998791816822,0.6131393997603659,0.5027214053133467,0.008718934592221506,0.42440542344409615,0.1087910413404577,0.7548046890745902,0.0034353918519983706,0.38411622695161873,0.8509075096352549,0.3817508916923361,0.2992639560594308,0.4800613306169378,0.31184671337294734,0.06771682237302357,0.8719231136830549,0.2003574411764486,0.68049293335178,0.8316137546952155,0.4255593624282551,0.40810480849202035,0.6466861789436046,0.5796041645912373,0.26479415910903004,0.8208167045988108,0.1043880897673991,0.223360494405766,0.13019957357938472,0.4619948060696183,0.4808089222190115,0.9274829315403137,0.20954386688564786,0.2824816575139403,0.2268088582012916,0.4541001914504047,0.32614365630696873,0.22182136319075763,0.4662118258704232,0.12110932675966846,0.35543619731325293,0.5907898155082696,0.7657155714929027,0.6073654499712545,0.8867993058553072,0.5377790915713087,0.2810303205051866,0.708610004911746,0.2780174995221253,0.30138695920089753,0.5889535021580034,0.343610983748067,0.16750690947811753,0.7140787276192216,0.1362046205287445,0.02482518053121363,0.5172674471819605,0.7462949392834274,0.37787531474982816,0.2450495351099261,0.6638771182214835,0.5739303303284594,0.2791452433315824,0.818420253618198,0.5100902387114473,0.9504224618371164,0.26037283160985447,0.6841271716140267,0.007028791149830238,0.0643466980251044,0.2343802307264542,0.04786172000724964,0.6931292246640635,0.1806874814282564,0.939583774670977,0.8881406975479517,0.6185432926090262,0.631978200283867,0.8096236003384627,0.19549233479598294,0.43665664804796145,0.26249510634556295,0.4580534895629501,0.9512431820781506,0.6575074545140448,0.15728144224666418,0.10093511975064373,0.9504228672627595,0.14202026213955465,0.3389460124967525,0.018435408054285563,0.8443149165607425,0.39760291276772863,0.014176182789015557,0.6808149432574485,0.004318213790142411,0.7432952878250526,0.2576748347785943,0.931370187176011,0.8948860835716037,0.1715997995859282,0.6689695110411319,0.9073393212885121,0.2960495994928768,0.8576719116207527,0.06371295230789664,0.34457206170295085,0.26414037482962227,0.640255842414711,0.4529374504328577,0.3774139738066784,0.3398821786914512,0.39951878196389057,0.6121547336662019,0.15384590674587606,0.20012966713601477,0.5212745217106141,0.6973442233323236,0.8701101165977201,0.21689199788922142,0.1623762231259519,0.9545401178885757,0.38326646804114206,0.23386818187222824],"marker":{}}];
            var layout = {"width":500,"height":500,"template":{"layout":{"title":{"x":0.05},"font":{"color":"rgba(42, 63, 95, 1.0)"},"paper_bgcolor":"rgba(255, 255, 255, 1.0)","plot_bgcolor":"rgba(229, 236, 246, 1.0)","autotypenumbers":"strict","colorscale":{"diverging":[[0.0,"#8e0152"],[0.1,"#c51b7d"],[0.2,"#de77ae"],[0.3,"#f1b6da"],[0.4,"#fde0ef"],[0.5,"#f7f7f7"],[0.6,"#e6f5d0"],[0.7,"#b8e186"],[0.8,"#7fbc41"],[0.9,"#4d9221"],[1.0,"#276419"]],"sequential":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]],"sequentialminus":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]},"hovermode":"closest","hoverlabel":{"align":"left"},"coloraxis":{"colorbar":{"outlinewidth":0.0,"ticks":""}},"geo":{"showland":true,"landcolor":"rgba(229, 236, 246, 1.0)","showlakes":true,"lakecolor":"rgba(255, 255, 255, 1.0)","subunitcolor":"rgba(255, 255, 255, 1.0)","bgcolor":"rgba(255, 255, 255, 1.0)"},"mapbox":{"style":"light"},"polar":{"bgcolor":"rgba(229, 236, 246, 1.0)","radialaxis":{"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","ticks":""},"angularaxis":{"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","ticks":""}},"scene":{"xaxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","gridwidth":2.0,"zerolinecolor":"rgba(255, 255, 255, 1.0)","backgroundcolor":"rgba(229, 236, 246, 1.0)","showbackground":true},"yaxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","gridwidth":2.0,"zerolinecolor":"rgba(255, 255, 255, 1.0)","backgroundcolor":"rgba(229, 236, 246, 1.0)","showbackground":true},"zaxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","gridwidth":2.0,"zerolinecolor":"rgba(255, 255, 255, 1.0)","backgroundcolor":"rgba(229, 236, 246, 1.0)","showbackground":true}},"ternary":{"aaxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)"},"baxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)"},"caxis":{"ticks":"","linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)"},"bgcolor":"rgba(229, 236, 246, 1.0)"},"xaxis":{"title":{"standoff":15},"ticks":"","automargin":true,"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","zerolinecolor":"rgba(255, 255, 255, 1.0)","zerolinewidth":2.0},"yaxis":{"title":{"standoff":15},"ticks":"","automargin":true,"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","zerolinecolor":"rgba(255, 255, 255, 1.0)","zerolinewidth":2.0},"annotationdefaults":{"arrowcolor":"#2a3f5f","arrowhead":0,"arrowwidth":1},"shapedefaults":{"line":{"color":"rgba(42, 63, 95, 1.0)"}},"colorway":["rgba(99, 110, 250, 1.0)","rgba(239, 85, 59, 1.0)","rgba(0, 204, 150, 1.0)","rgba(171, 99, 250, 1.0)","rgba(255, 161, 90, 1.0)","rgba(25, 211, 243, 1.0)","rgba(255, 102, 146, 1.0)","rgba(182, 232, 128, 1.0)","rgba(255, 151, 255, 1.0)","rgba(254, 203, 82, 1.0)"]},"data":{"bar":[{"marker":{"line":{"color":"rgba(229, 236, 246, 1.0)","width":0.5},"pattern":{"fillmode":"overlay","size":10,"solidity":0.2}},"error_x":{"color":"rgba(42, 63, 95, 1.0)"},"error_y":{"color":"rgba(42, 63, 95, 1.0)"}}],"barpolar":[{"marker":{"line":{"color":"rgba(229, 236, 246, 1.0)","width":0.5},"pattern":{"fillmode":"overlay","size":10,"solidity":0.2}}}],"carpet":[{"aaxis":{"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","endlinecolor":"rgba(42, 63, 95, 1.0)","minorgridcolor":"rgba(255, 255, 255, 1.0)","startlinecolor":"rgba(42, 63, 95, 1.0)"},"baxis":{"linecolor":"rgba(255, 255, 255, 1.0)","gridcolor":"rgba(255, 255, 255, 1.0)","endlinecolor":"rgba(42, 63, 95, 1.0)","minorgridcolor":"rgba(255, 255, 255, 1.0)","startlinecolor":"rgba(42, 63, 95, 1.0)"}}],"choropleth":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"contour":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"contourcarpet":[{"colorbar":{"outlinewidth":0.0,"ticks":""}}],"heatmap":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"heatmapgl":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"histogram":[{"marker":{"pattern":{"fillmode":"overlay","size":10,"solidity":0.2}}}],"histogram2d":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"histogram2dcontour":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"mesh3d":[{"colorbar":{"outlinewidth":0.0,"ticks":""}}],"parcoords":[{"line":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"pie":[{"automargin":true}],"scatter":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scatter3d":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}},"line":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scattercarpet":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scattergeo":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scattergl":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scattermapbox":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scatterpolar":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scatterpolargl":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"scatterternary":[{"marker":{"colorbar":{"outlinewidth":0.0,"ticks":""}}}],"surface":[{"colorbar":{"outlinewidth":0.0,"ticks":""},"colorscale":[[0.0,"#0d0887"],[0.1111111111111111,"#46039f"],[0.2222222222222222,"#7201a8"],[0.3333333333333333,"#9c179e"],[0.4444444444444444,"#bd3786"],[0.5555555555555556,"#d8576b"],[0.6666666666666666,"#ed7953"],[0.7777777777777778,"#fb9f3a"],[0.8888888888888888,"#fdca26"],[1.0,"#f0f921"]]}],"table":[{"cells":{"fill":{"color":"rgba(235, 240, 248, 1.0)"},"line":{"color":"rgba(255, 255, 255, 1.0)"}},"header":{"fill":{"color":"rgba(200, 212, 227, 1.0)"},"line":{"color":"rgba(255, 255, 255, 1.0)"}}}]}}};
            var config = {"responsive":true};
            Plotly.newPlot('531a67d9-741c-427a-8e99-f0877d9cae54', data, layout, config);
});
            };
            if ((typeof(requirejs) !==  typeof(Function)) || (typeof(requirejs.config) !== typeof(Function))) {
                var script = document.createElement("script");
                script.setAttribute("src", "https://cdnjs.cloudflare.com/ajax/libs/require.js/2.3.6/require.min.js");
                script.onload = function(){
                    renderPlotly_531a67d9741c427a8e99f0877d9cae54();
                };
                document.getElementsByTagName("head")[0].appendChild(script);
            }
            else {
                renderPlotly_531a67d9741c427a8e99f0877d9cae54();
            }
</script>
*)

