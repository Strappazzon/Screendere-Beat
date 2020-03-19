<h1 align="center">
  <br>
  <img src="https://strappazzon.xyz/Screendere-Beat/assets/img/screenshot.png" alt="Screendere Beat"></a>
  <br>
  Screendere Beat
  <br>
</h1>

<h4 align="center">Capture screenshots of Hinedere Beat's uncensored version.</h4>

<p align="center">
  <a href="https://strappazzon.xyz/Screendere-Beat"><img alt="HTML Version" src="https://img.shields.io/badge/HTML%20Version-%23ff5f2f?style=flat-square&logo=HTML5&logoColor=%23ffffff"></a>
  <img alt="GitHub All Releases" src="https://img.shields.io/github/downloads/Strappazzon/Screendere-Beat/total?color=%23085d9d&label=Downloads&logo=DocuSign&logoColor=%23ffffff&style=flat-square">
  <a href="https://github.com/Strappazzon/Screendere-Beat/releases/latest"><img alt="Latest Release" src="https://img.shields.io/github/v/release/Strappazzon/Screendere-Beat?color=%23a040d0&include_prereleases&label=Latest%20Release&style=flat-square"></a>
  <a href="https://travis-ci.org/Strappazzon/Screendere-Beat/builds"><img alt="Build Status" src="https://img.shields.io/travis/Strappazzon/Screendere-Beat?color=%23724cdb&label=Build&logo=travis-ci&logoColor=%23ffffff&style=flat-square"></a>
</p>

<p align="center">
  <a href="#about">About</a> •
  <a href="#getting-started">Getting Started</a> •
  <a href="#settings">Settings</a> •
  <a href="#download">Download</a> •
  <a href="#license">License</a>
</p>

## About

**Screendere Beat** is a small software to take screenshots of Hinedere Beat.

I created it because the developer disabled the ability to take screenshots in the Steam version when launching the game in its [uncensored state](https://www.blazeepic.com/uploads/2/2/4/4/22443112/hinederebeat_uncensor.txt).

## Getting Started

* Launch **Screendere Beat.exe**.
  * Every time you launch it, the program will check the System Registry to see if Steam is installed.
  * When you close it, a file containing its settings will be created (or updated if it already exists) inside `%LOCALAPPDATA%\Screendere`

* Type your Steam ID inside the **Your Steam ID** field.

> ### :video_game: How to get your Steam ID
>
> * Go to <https://steamcommunity.com/id/my/tradeoffers/privacy>
> * Scroll down the page until you find your **Trade URL**, under **Third-Party Sites**.
>   * The trade URL looks like this: `https://steamcommunity.com/tradeoffer/new/?partner=1234567890&token=T0k3N`
> * The number between `?partner=` and `&token=` is your ID.
>   * In this example your ID would be `1234567890`

* Tick **Play a Sound** if you want to hear a sound whenever a screenshot is taken.

* [Run](steam://run/759220) Hinedere Beat.

* Press the **F12** key to capture a screenshot.
  * It's not possible to customize Screendere Beat's screenshot key (at least for now).

### Uploading the Screenshots to Steam Cloud

Steam normally doesn't allow you to upload custom screenshots.

You can work around it by either:

* Manually [modifying screenshots.vdf](https://gaming.stackexchange.com/a/282581)
* Using [SteaScree](https://steascree.download/)

## Settings

* **Your Steam ID**
  * _Empty by default_
  * Needed to create the screenshot save path

* **Play a Sound**
  * _Disabled by default_
  * Play a sound when a screenshot is taken

All settings are stored inside `%LOCALAPPDATA%\Screendere`

## Download

You can [download](https://github.com/Strappazzon/Screendere-Beat/releases/latest) the latest version of Screendere Beat from the Releases page.

## Contributing

If you are interested in fixing issues and contributing directly to the code base, please see:

* [Building Screendere Beat from its source code](https://github.com/Strappazzon/Screendere-Beat/blob/master/BUILDING.md)
* [Contribution Guidelines](./CONTRIBUTING.md)
* [Code of Conduct](./CODE_OF_CONDUCT.md)

## License

```
Copyright (c) 2019 - 2020 Alberto Strappazzon

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
