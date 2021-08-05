﻿module Tests.SimpleCharts

open Expecto
open Plotly.NET
open TestUtils
open Plotly.NET.GenericChart

let withLineStyleChart =
    let x  = [1.; 2.; 3.; 4.; 5.; 6.; 7.; 8.; 9.; 10.; ]
    let y = [2.; 1.5; 5.; 1.5; 3.; 2.5; 2.5; 1.5; 3.5; 1.]
    Chart.Line(
        x,y,
        Name="line",
        ShowMarkers=true,
        MarkerSymbol=StyleParam.Symbol.Square)    
    |> Chart.withLineStyle(Width=2.,Dash=StyleParam.DrawingStyle.Dot)

let chartLineChart =
    [ for x in 1.0 .. 100.0 -> (x, x ** 2.0) ]
    |> Chart.Line

let splineChart =
    let x  = [1.; 2.; 3.; 4.; 5.; 6.; 7.; 8.; 9.; 10.; ]
    let y = [2.; 1.5; 5.; 1.5; 3.; 2.5; 2.5; 1.5; 3.5; 1.]
    Chart.Spline(x, y, Name="spline")   

let textLabelChart =
    let x  = [1.; 2.; 3.; 4.; 5.; 6.; 7.; 8.; 9.; 10.; ]
    let y = [2.; 1.5; 5.; 1.5; 3.; 2.5; 2.5; 1.5; 3.5; 1.]
    let labels  = ["a";"b";"c";"d";"e";"f";"g";"h";"i";"j";]
    Chart.Point(
        x,y,
        Name="points",
        Labels=labels,
        TextPosition=StyleParam.TextPosition.TopRight
    )

[<Tests>]
let ``Line and scatter plots`` =
    testList "Line and scatter plots" [
        testCase "With LineStyle data" ( fun () ->
            "var data = [{\"type\":\"scatter\",\"x\":[1.0,2.0,3.0,4.0,5.0,6.0,7.0,8.0,9.0,10.0],\"y\":[2.0,1.5,5.0,1.5,3.0,2.5,2.5,1.5,3.5,1.0],\"mode\":\"lines+markers\",\"line\":{\"width\":2.0,\"dash\":\"dot\"},\"name\":\"line\",\"marker\":{\"symbol\":1}}];"
            |> chartGeneratedContains withLineStyleChart
        );
        testCase "With LineStyle layout" ( fun () ->
            emptyLayout withLineStyleChart
        );
        testCase "Chart line data" ( fun () ->
            "var data = [{\"type\":\"scatter\",\"x\":[1.0,2.0,3.0,4.0,5.0,6.0,7.0,8.0,9.0,10.0,11.0,12.0,13.0,14.0,15.0,16.0,17.0,18.0,19.0,20.0,21.0,22.0,23.0,24.0,25.0,26.0,27.0,28.0,29.0,30.0,31.0,32.0,33.0,34.0,35.0,36.0,37.0,38.0,39.0,40.0,41.0,42.0,43.0,44.0,45.0,46.0,47.0,48.0,49.0,50.0,51.0,52.0,53.0,54.0,55.0,56.0,57.0,58.0,59.0,60.0,61.0,62.0,63.0,64.0,65.0,66.0,67.0,68.0,69.0,70.0,71.0,72.0,73.0,74.0,75.0,76.0,77.0,78.0,79.0,80.0,81.0,82.0,83.0,84.0,85.0,86.0,87.0,88.0,89.0,90.0,91.0,92.0,93.0,94.0,95.0,96.0,97.0,98.0,99.0,100.0],\"y\":[1.0,4.0,9.0,16.0,25.0,36.0,49.0,64.0,81.0,100.0,121.0,144.0,169.0,196.0,225.0,256.0,289.0,324.0,361.0,400.0,441.0,484.0,529.0,576.0,625.0,676.0,729.0,784.0,841.0,900.0,961.0,1024.0,1089.0,1156.0,1225.0,1296.0,1369.0,1444.0,1521.0,1600.0,1681.0,1764.0,1849.0,1936.0,2025.0,2116.0,2209.0,2304.0,2401.0,2500.0,2601.0,2704.0,2809.0,2916.0,3025.0,3136.0,3249.0,3364.0,3481.0,3600.0,3721.0,3844.0,3969.0,4096.0,4225.0,4356.0,4489.0,4624.0,4761.0,4900.0,5041.0,5184.0,5329.0,5476.0,5625.0,5776.0,5929.0,6084.0,6241.0,6400.0,6561.0,6724.0,6889.0,7056.0,7225.0,7396.0,7569.0,7744.0,7921.0,8100.0,8281.0,8464.0,8649.0,8836.0,9025.0,9216.0,9409.0,9604.0,9801.0,10000.0],\"mode\":\"lines\",\"line\":{},\"marker\":{}}];"
            |> chartGeneratedContains chartLineChart
        );
        testCase "Chart line layout" ( fun () ->
            emptyLayout chartLineChart
        );
        testCase "Spline chart data" ( fun () ->
            "var data = [{\"type\":\"scatter\",\"x\":[1.0,2.0,3.0,4.0,5.0,6.0,7.0,8.0,9.0,10.0],\"y\":[2.0,1.5,5.0,1.5,3.0,2.5,2.5,1.5,3.5,1.0],\"mode\":\"lines\",\"name\":\"spline\",\"line\":{\"shape\":\"spline\"},\"marker\":{}}];"
            |> chartGeneratedContains splineChart
        );
        testCase "Spline chart layout" ( fun () ->
            emptyLayout splineChart
        );
        testCase "Text label data" ( fun () ->
            "var data = [{\"type\":\"scatter\",\"x\":[1.0,2.0,3.0,4.0,5.0,6.0,7.0,8.0,9.0,10.0],\"y\":[2.0,1.5,5.0,1.5,3.0,2.5,2.5,1.5,3.5,1.0],\"mode\":\"markers+text\",\"name\":\"points\",\"marker\":{},\"text\":[\"a\",\"b\",\"c\",\"d\",\"e\",\"f\",\"g\",\"h\",\"i\",\"j\"],\"textposition\":\"top right\"}];"
            |> chartGeneratedContains textLabelChart
        );
        testCase "Text label layout" ( fun () ->
            emptyLayout textLabelChart
        );
    ]


let columnChart =
    let values = [20; 14; 23;]
    let keys   = ["Product A"; "Product B"; "Product C";]
    Chart.Column(keys, values)

let barChart =
    let values = [20; 14; 23;]
    let keys   = ["Product A"; "Product B"; "Product C";]
    Chart.Bar(keys, values)

let stackedBarChart =
    let values = [20; 14; 23;]
    let keys   = ["Product A"; "Product B"; "Product C";]
    [
        Chart.StackedBar(keys,values,Name="old");
        Chart.StackedBar(keys,[8; 21; 13;],Name="new")
    ]
    |> Chart.Combine

let stackedColumnChart =
    let values = [20; 14; 23;]
    let keys   = ["Product A"; "Product B"; "Product C";]
    [
        Chart.StackedColumn(keys,values,Name="old");
        Chart.StackedColumn(keys,[8; 21; 13;],Name="new")
    ]
    |> Chart.Combine

[<Tests>]
let ``Bar and column charts`` =
    testList "Bar and column charts" [
        testCase "Column chart data" ( fun () ->
            "var data = [{\"type\":\"bar\",\"x\":[\"Product A\",\"Product B\",\"Product C\"],\"y\":[20,14,23],\"marker\":{}}];"
            |> chartGeneratedContains columnChart
        );
        testCase "Column chart layout" ( fun () ->
            emptyLayout columnChart
        );
        testCase "Bar chart data" ( fun () ->
            "var data = [{\"type\":\"bar\",\"x\":[20,14,23],\"y\":[\"Product A\",\"Product B\",\"Product C\"],\"orientation\":\"h\",\"marker\":{}}];"
            |> chartGeneratedContains barChart
        );
        testCase "Bar chart layout" ( fun () ->
            emptyLayout barChart
        );
        testCase "Stacked bar data" ( fun () ->
            "var data = [{\"type\":\"bar\",\"x\":[20,14,23],\"y\":[\"Product A\",\"Product B\",\"Product C\"],\"orientation\":\"h\",\"marker\":{},\"name\":\"old\"},{\"type\":\"bar\",\"x\":[8,21,13],\"y\":[\"Product A\",\"Product B\",\"Product C\"],\"orientation\":\"h\",\"marker\":{},\"name\":\"new\"}];"
            |> chartGeneratedContains stackedBarChart
        );
        testCase "Stacked bar layout" ( fun () ->
            "var layout = {\"barmode\":\"stack\"};"
            |> chartGeneratedContains stackedColumnChart
        );
        testCase "Stacked column data" ( fun () ->
            "var data = [{\"type\":\"bar\",\"x\":[\"Product A\",\"Product B\",\"Product C\"],\"y\":[20,14,23],\"marker\":{},\"name\":\"old\"},{\"type\":\"bar\",\"x\":[\"Product A\",\"Product B\",\"Product C\"],\"y\":[8,21,13],\"marker\":{},\"name\":\"new\"}];"
            |> chartGeneratedContains stackedColumnChart
        );
        testCase "Stacked column layout" ( fun () ->
            "var layout = {\"barmode\":\"stack\"};"
            |> chartGeneratedContains stackedColumnChart
        );
    ]


let simpleAreaChart =
    let x  = [1.; 2.; 3.; 4.; 5.; 6.; 7.; 8.; 9.; 10.; ]
    let y  = [5.; 2.5; 5.; 7.5; 5.; 2.5; 7.5; 4.5; 5.5; 5.]
    Chart.Area(x,y)

let withSplineChart =
    let x  = [1.; 2.; 3.; 4.; 5.; 6.; 7.; 8.; 9.; 10.; ]
    let y  = [5.; 2.5; 5.; 7.5; 5.; 2.5; 7.5; 4.5; 5.5; 5.]
    Chart.SplineArea(x,y)

let stackedAreaChart =
    let x  = [1.; 2.; 3.; 4.; 5.; 6.; 7.; 8.; 9.; 10.; ]
    let y  = [5.; 2.5; 5.; 7.5; 5.; 2.5; 7.5; 4.5; 5.5; 5.]
    [
        Chart.StackedArea(x,y)
        Chart.StackedArea(x,y |> Seq.rev)
    ]
    |> Chart.Combine

[<Tests>]
let ``Area charts`` =
    testList "Area charts" [
        testCase "Simple area data" ( fun () ->
            "var data = [{\"type\":\"scatter\",\"x\":[1.0,2.0,3.0,4.0,5.0,6.0,7.0,8.0,9.0,10.0],\"y\":[5.0,2.5,5.0,7.5,5.0,2.5,7.5,4.5,5.5,5.0],\"mode\":\"lines\",\"fill\":\"tozeroy\",\"line\":{},\"marker\":{}}];"
            |> chartGeneratedContains simpleAreaChart
        );
        testCase "Simple area layout" ( fun () ->
            emptyLayout simpleAreaChart
        );
        testCase "Spline data" ( fun () ->
            "var data = [{\"type\":\"scatter\",\"x\":[1.0,2.0,3.0,4.0,5.0,6.0,7.0,8.0,9.0,10.0],\"y\":[5.0,2.5,5.0,7.5,5.0,2.5,7.5,4.5,5.5,5.0],\"mode\":\"lines\",\"fill\":\"tozeroy\",\"line\":{\"shape\":\"spline\"},\"marker\":{}}];"
            |> chartGeneratedContains withSplineChart
        );
        testCase "Spline layout" ( fun () ->
            emptyLayout withSplineChart
        );
        testCase "Stacked area data" ( fun () ->
            "var data = [{\"type\":\"scatter\",\"x\":[1.0,2.0,3.0,4.0,5.0,6.0,7.0,8.0,9.0,10.0],\"y\":[5.0,2.5,5.0,7.5,5.0,2.5,7.5,4.5,5.5,5.0],\"mode\":\"lines\",\"line\":{},\"marker\":{},\"stackgroup\":\"static\"},{\"type\":\"scatter\",\"x\":[1.0,2.0,3.0,4.0,5.0,6.0,7.0,8.0,9.0,10.0],\"y\":[5.0,5.5,4.5,7.5,2.5,5.0,7.5,5.0,2.5,5.0],\"mode\":\"lines\",\"line\":{},\"marker\":{},\"stackgroup\":\"static\"}];"
            |> chartGeneratedContains stackedAreaChart
        );
        testCase "Stacked area layout" ( fun () ->
            emptyLayout stackedAreaChart
        );
    ]


let rangePlotsChart =
    let rnd = System.Random(5)
    
    let x  = [1.; 2.; 3.; 4.; 5.; 6.; 7.; 8.; 9.; 10.; ]
    let y = [2.; 1.5; 5.; 1.5; 3.; 2.5; 2.5; 1.5; 3.5; 1.]
    
    let yUpper = y |> List.map (fun v -> v + rnd.NextDouble())
    let yLower = y |> List.map (fun v -> v - rnd.NextDouble())
    Chart.Range(
        x,y,yUpper,yLower,
        StyleParam.Mode.Lines_Markers,
        Color="grey",
        RangeColor="lightblue")


[<Tests>]
let ``Range plot`` =
    testList "Range plot" [
        testCase "Range plot data" ( fun () ->
            "var data = [{\"type\":\"scatter\",\"x\":[1.0,2.0,3.0,4.0,5.0,6.0,7.0,8.0,9.0,10.0],\"y\":[1.0244410755226578,1.1291130737537114,4.930085632917511,1.4292117752736488,2.5179894182449156,2.3470285278032668,1.5358344954605374,1.4046562835130172,2.6874669190437843,0.7493837949584163],\"mode\":\"lines\",\"fillcolor\":\"lightblue\",\"name\":\"lower\",\"showlegend\":false,\"line\":{\"width\":0.0},\"marker\":{\"color\":\"lightblue\"}},{\"type\":\"scatter\",\"x\":[1.0,2.0,3.0,4.0,5.0,6.0,7.0,8.0,9.0,10.0],\"y\":[2.338369840913624,1.7844184475412679,5.2629626417825754,2.125375844363764,3.4634618528482792,3.4283738280312965,2.6463105539541276,2.4505998873853123,4.096133255211699,1.1174599459010455],\"mode\":\"lines\",\"fill\":\"tonexty\",\"fillcolor\":\"lightblue\",\"name\":\"upper\",\"showlegend\":false,\"line\":{\"width\":0.0},\"marker\":{\"color\":\"lightblue\"}},{\"type\":\"scatter\",\"x\":[1.0,2.0,3.0,4.0,5.0,6.0,7.0,8.0,9.0,10.0],\"y\":[2.0,1.5,5.0,1.5,3.0,2.5,2.5,1.5,3.5,1.0],\"mode\":\"lines+markers\",\"fillcolor\":\"grey\",\"line\":{\"color\":\"grey\"},\"marker\":{\"color\":\"grey\"}}];"
            |> chartGeneratedContains rangePlotsChart
        );
        testCase "Range plot layout" ( fun () ->
            emptyLayout rangePlotsChart
        );
    ]

let bubbleCharts =
    let x = [2; 4; 6;]
    let y = [4; 1; 6;]
    let size = [19; 26; 55;]
    Chart.Bubble(x, y, size)

[<Tests>]
let ``Bubble charts`` =
    testList "Bubble charts" [
        testCase "Bubble data" ( fun () ->
            "var data = [{\"type\":\"scatter\",\"x\":[2,4,6],\"y\":[4,1,6],\"mode\":\"markers\",\"marker\":{\"size\":[19,26,55]}}];"
            |> chartGeneratedContains bubbleCharts
        );
        testCase "Bubble layout" ( fun () ->
            emptyLayout bubbleCharts
        );
    ]

let pieChart =
    let values = [19; 26; 55;]
    let labels = ["Residential"; "Non-Residential"; "Utility"]
    Chart.Pie(values, labels)

let doughnutChart =
    let values = [19; 26; 55;]
    let labels = ["Residential"; "Non-Residential"; "Utility"]
    Chart.Doughnut(
        values,
        labels,
        Hole=0.3,
        Textinfo=labels
    )

let sunburstChart =
    let values = [19; 26; 55;]
    let labels = ["Residential"; "Non-Residential"; "Utility"]
    Chart.Sunburst(
        ["A";"B";"C";"D";"E"],
        ["";"";"B";"B";""],
        Values=[5.;0.;3.;2.;3.],
        Text=["At";"Bt";"Ct";"Dt";"Et"]
    )

[<Tests>]
let ``Pie and doughnut Charts`` =
    testList "Pie and doughnut Charts" [
        testCase "Pie data" ( fun () ->
            "var data = [{\"type\":\"pie\",\"values\":[19,26,55],\"labels\":[\"Residential\",\"Non-Residential\",\"Utility\"],\"marker\":{},\"text\":[\"Residential\",\"Non-Residential\",\"Utility\"]}];"
            |> chartGeneratedContains pieChart
        );
        testCase "Pie layout" ( fun () ->
            emptyLayout pieChart
        );
        testCase "Doughnut data" ( fun () ->
            "var data = [{\"type\":\"pie\",\"values\":[19,26,55],\"labels\":[\"Residential\",\"Non-Residential\",\"Utility\"],\"textinfo\":[\"Residential\",\"Non-Residential\",\"Utility\"],\"hole\":0.3,\"marker\":{},\"text\":[\"Residential\",\"Non-Residential\",\"Utility\"]}];"
            |> chartGeneratedContains doughnutChart
        );
        testCase "Doughnut layout" ( fun () ->
            emptyLayout doughnutChart
        );
        testCase "Sunburst data" ( fun () ->
            "var data = [{\"type\":\"sunburst\",\"labels\":[\"A\",\"B\",\"C\",\"D\",\"E\"],\"parents\":[\"\",\"\",\"B\",\"B\",\"\"],\"values\":[5.0,0.0,3.0,2.0,3.0],\"text\":[\"At\",\"Bt\",\"Ct\",\"Dt\",\"Et\"],\"marker\":{}}];"
            |> chartGeneratedContains sunburstChart
        );
        testCase "Sunburst layout" ( fun () ->
            emptyLayout sunburstChart
        );
    ]