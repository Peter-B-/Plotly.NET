(**
[![Binder](https://plotly.net/img/badge-binder.svg)](https://mybinder.org/v2/gh/plotly/Plotly.NET/gh-pages?filepath=00_1_image-export.ipynb)&emsp;
[![Script](https://plotly.net/img/badge-script.svg)](https://plotly.net/00_1_image-export.fsx)&emsp;
[![Notebook](https://plotly.net/img/badge-notebook.svg)](https://plotly.net/00_1_image-export.ipynb)

# Static image export

### Table of contents

* [Saving static images](#Saving-static-images)

* [Generating URIs for static chart images](#Generating-URIs-for-static-chart-images)

* [Including static images in dotnet interactive notebooks](#Including-static-images-in-dotnet-interactive-notebooks)

As Plotly.NET generates static html pages that contain charts rendered by plotly.js, static image export needs a lot more overhead under the hood
than you might expect. The underlying renderer needs to execute javascript, leading to the usage of headless browsers.

The package `Plotly.NET.ImageExport` contains extensions for Plotly.NET to render static images. It is designed with extensibility in mind and
it is very easy to add a new rendering engine. The current engines are provided:

Rendering engine | Type | Prerequisites
--- | --- | ---
[PuppeteerSharp](https://github.com/hardkoded/puppeteer-sharp) | headless browser | [read more here](https://github.com/hardkoded/puppeteer-sharp#prerequisites)


## Saving static images

By referencing the `Plotly.NET.ImageExport` package, you get access to:

* jpg via `Chart.SaveJPG`

* png via `Chart.SavePNG`

* svg via `Chart.SaveSVG`

(and Extensions for C# style fluent interfaces by opening the `GenericChartExtensions` namespace)

The parameters for all three functions are exactly the same.

*)
open Plotly.NET
open Plotly.NET.ImageExport

let exampleChart = 
    Chart.Histogram2DContour(
        [1.;2.;2.;4.;5.],
        [1.;2.;2.;4.;5.]
    )
exampleChart
|> Chart.saveJPG(
    "/your/path/without/extension/here",
    Width=300,
    Height=300
)(* output: 
<img
    src= "data:image/jpeg;base64,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IaWtFjp6iUzyw22hipmSSHre5sbQC7znmrsaloOPXAocLyUjt0RFaKwoMsmkNHXTjXR3vhbYaW2w6YrK12qL9TZabrVSwyR+5xfnNSY5JGzSOdkROiYxvjF4ZOatG28IeE1mv7dV2fhfpKhvbJXztuVNZKaKqEjwQ94lawP3ODnZOcncc9auU5qKZRKOtYu5ERWysLF7utNVR1wqdO3eh1DT2rTj7VcIHwWOump7jXyVkWCZ4onRbIIt/iudl0srcDdG3OUKpbla7ZeaN9uvFupa6kkcxz4KmFssbi1wc0lrgQSHNa4eQgHsVylNU5qTRROLnGyPpR1UVfSQV0AlEVRG2VglidE8NcMjcx4DmnB5tcAR1EAr7IitlYULd0lDfLxNw+0ZROtzLXqTUporkbm2R9FIG0VTLDFURxvY6VjpI2kRb2iR7GMJw4gzSqC+WCxantk1k1LZaC7W6pAE1JXUzJ4ZADkbmPBaeYB5hV05aktYplHWVix+AtxpKrQ09porDZbVHYLxcbN0dkiMVvldBUPDpadhJ2McSSWZdtdvbk4yZHVJa7Va7Hb4LRZLbS2+hpWCOClpYWxRRMHxWsaAGjzAKrXyb1pNo+xVlYIiKk+hERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREB//Z"
/>*)
(**
## Generating URIs for static chart images

By referencing the `Plotly.NET.ImageExport` package, you get access to:

* jpg via `Chart.toBase64JPGString`

* png via `Chart.toBase64PNGString`

* svg via `Chart.toSVGString`

(and Extensions for C# style fluent interfaces by opening the `GenericChartExtensions` namespace)

*)
let base64JPG =
    exampleChart
    |> Chart.toBase64JPGString(
        Width=300,
        Height=300
    )
(**
It is very easy to construct a html tag that includes this image via a base64 uri. For SVGs,
not even that is necessary and just the SVG string can be used.

*)
$"""<img
    src= "{base64JPG}"
/>"""(* output: 
<img
    src= "data:image/jpeg;base64,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IaWtFjp6iUzyw22hipmSSHre5sbQC7znmrsaloOPXAocLyUjt0RFaKwoMsmkNHXTjXR3vhbYaW2w6YrK12qL9TZabrVSwyR+5xfnNSY5JGzSOdkROiYxvjF4ZOatG28IeE1mv7dV2fhfpKhvbJXztuVNZKaKqEjwQ94lawP3ODnZOcncc9auU5qKZRKOtYu5ERWysLF7utNVR1wqdO3eh1DT2rTj7VcIHwWOump7jXyVkWCZ4onRbIIt/iudl0srcDdG3OUKpbla7ZeaN9uvFupa6kkcxz4KmFssbi1wc0lrgQSHNa4eQgHsVylNU5qTRROLnGyPpR1UVfSQV0AlEVRG2VglidE8NcMjcx4DmnB5tcAR1EAr7IitlYULd0lDfLxNw+0ZROtzLXqTUporkbm2R9FIG0VTLDFURxvY6VjpI2kRb2iR7GMJw4gzSqC+WCxantk1k1LZaC7W6pAE1JXUzJ4ZADkbmPBaeYB5hV05aktYplHWVix+AtxpKrQ09porDZbVHYLxcbN0dkiMVvldBUPDpadhJ2McSSWZdtdvbk4yZHVJa7Va7Hb4LRZLbS2+hpWCOClpYWxRRMHxWsaAGjzAKrXyb1pNo+xVlYIiKk+hERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREB//Z"
/>*)
(**
SVGs can be included without the image tag:

*)
let svgString =
    exampleChart
    |> Chart.toSVGString(
        Width=300,
        Height=300
    )

svgString.Substring(0,300)
|> printfn "%s"(* output: 
<svg class="main-svg" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="300" height="300" style="" viewBox="0 0 300 300"><rect x="0" y="0" width="300" height="300" style="fill: rgb(255, 255, 255); fill-opacity: 1;"/><defs id="defs-2dd509"><g class="clips"><clipPath*)
(**
In fact, the images shown on this site are included just the same way.

## Including static images in dotnet interactive notebooks

To include the images in dotnet interactive, convert them to html tags as above and include them via
dotnet interactive's `DisplayAs` function. The content type for PNG/JPG is "text/html", and "image/svg+xml" for SVG.

*)
let base64PNGTag =
    let base64 =
        exampleChart
        |> Chart.toBase64PNGString(
            Width=300,
            Height=300
        )
    $"""<img src= "{base64JPG}"/>"""

let svgString2 =
    exampleChart
    |> Chart.toSVGString(
        Width=300,
        Height=300
    )

// DisplayExtensions.DisplayAs(base64PNG,"text/html")
// DisplayExtensions.DisplayAs(svgString2,"image/svg+xml")

