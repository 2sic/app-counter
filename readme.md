<image src="app-icon.png" align="right" width="200px">

# Counter 2 App for .net CMSs

> This is a [2sxc](https://2sxc.org) App for [DNN ☢️](https://www.dnnsoftware.com/) and [Oqtane 💧](https://www.oqtane.org/)

A Fact/Number Counter App to show facts in a dynamic way


| Aspect              | Status | Comments or Version
| ------------------- | :----: | -------------------
| 2sxc                | ✅    | requires 2sxc v17.07.00
| Dnn                 | ✅    | For 09.06.01
| Oqtane              | ✅    | Requires v05.00+
| No jQuery           | ✅    |
| Live Demo           | ➖    |
| Install Checklist   | ✅    | See [Installation](https://azing.org/2sxc/r/wD0h-932) on [azing.org](https://azing.org/2sxc)
| Source & License    | ✅    | included, ISC/MIT
| App Catalog         | ✅    | See [app catalog](https://2sxc.org/en/apps/app/counter2-hybrid-for-dnn-and-oqtane)
| Screenshots         | ✅    | See [app catalog](https://2sxc.org/en/apps/app/counter2-hybrid-for-dnn-and-oqtane)
| Best Practices      | ✅    | Uses v13.10 conventions
| Bootstrap 3         | ✅    |
| Bootstrap 4         | ✅    |
| Bootstrap 5         | ✅    |

## Customize the App

The Counter App doesn't use any app settings or app resources.

If you want to customize the CSS, you will usually follow the ["Create Custom Styles in a Standard 2sxc App" checklist](https://azing.org/2sxc/r/gg_aB9FD)

## History

* v02.00.00 2021-09
  * Updated to best-practices of 2sxc 12.05
  * Hybrid, so it works with Oqtane
  * Tested to look ok on Bootstrap5
* v02.02.00 2022-04
  * Changed services to use ToSic.Sxc.Services
  * Activated image configuration
* v02.03.00 2022-06
  * Replaced all base classes with their 2sxc 14 equivalents
  * Removed all GetService<> and switched to the new ServiceKit14
  * Changed all toolbars to use the IToolbarService
* v02.04.00 2023-09
  * Removed _ from Filenames
  * Upgraded to conventions 16.02
  * Changed all code to be typed
  * Remove bs3 Code and call the bs4 file
  * less duplicated code, one Assets file in bs5
* v02.17.00 2024-04
  * Strong Typed
  * Auto Generated Class
  * Typed MyItem
* v02.17.01 2024-07
  * Update app.sln and app.csproj
* v02.21.00 2026-03
  * Added intellisense Extensions for Visual Studio Code
* v02.21.01 2026-06
  * Switched from webpack to Vite for faster builds
  