---
title: API Documentation | Stock Indicators
description: >-
  Transform financial market prices into technical analysis insights with this self-hosted .NET Web API.
permalink: /
layout: base
lazy-images: true
---

<h1 style="display:none;">{{ page.title }}</h1>

> 🚧 **This documentation and related API is under development.**
>
> We're just getting started with development and are seeking stock indicator enthusiasts to build and maintain this open-source project.  [Learn how you can contribute]({{site.baseurl}}/contributing/#content) to make this API available to others.

<h2>Reputable and extensible indicators</h2>

**Stock Indicators API** is a self-hosted REST API that converts financial market price quotes into trade indicators.  It's a language agnostic HTTP interface to our [popular NuGet library](https://dotnet.stockindicators.dev).  Both the library and this API are built with the latest .NET technology.  It can be hosted in almost any environment and operating system (Linux, Windows, MacOS, etc.).

Explore more information:

- [Getting started]({{site.github.repository_url}}/#readme) (and host setup)
- [Demo site](https://charts.stockindicators.dev/) (a stock chart)
- [Release notes]({{site.github.repository_url}}/releases)
- [Discussions]({{site.github.repository_url}}/discussions)
- [Contributing guidelines]({{site.baseurl}}/contributing/#content)
- [Terms of service]({{site.baseurl}}/terms/#content)

## Licensed for everyone

<a href="https://opensource.org/licenses/Apache-2.0"><img src="https://img.shields.io/badge/License-Apache%202.0-blue.svg?style=flat-square&cacheSeconds=259200" alt="Apache 2.0 license badge" width="124" height="20" class="lazyload" /></a>

This repository uses the standard Apache 2.0 open-source license.  Please review the [license](https://opensource.org/licenses/Apache-2.0) before using or contributing to the software.

## Share your ideas with the community

**Need help?**  Have ideas?  [Start a new discussion, ask a question &#128172;]({{site.github.repository_url}}/discussions), or [submit an issue]({{site.github.repository_url}}/issues) if it is publicly relevant.  You can also direct message [@daveskender](https://twitter.com/messages/compose?recipient_id=27475431).

## Give back with patronage

Thank you for your support!  This software is crafted with care by unpaid enthusiasts who &#128150; all forms of encouragement.  If you or your organization use this library or like what we're doing, add a &#11088; on the [GitHub Repo]({{site.github.repository_url}}) as a token of appreciation.

If you want to buy me a beer or are interested in ongoing support as a patron, [become a sponsor](https://github.com/sponsors/DaveSkender).  Patronage motivates continued maintenance and evolution of open-source projects, and to inspire new ones.

## Contribute to help others

This API is an open-source project [on GitHub](https://github.com/DaveSkender/Stock.Indicators.Api).  If you want to report bugs or contribute fixes, new indicators, or new features, please review our [contributing guidelines]({{site.baseurl}}/contributing/#content).

Special thanks to all of our community code contributors!

<ul class="list-style-none">
{% for contributor in site.github.contributors %}
  <li class="d-inline-block">
     <a href="{{ contributor.html_url }}" width="75" height="75"><img data-src="{{ contributor.avatar_url }}&s=75" width="75" height="75" class="circle lazyload" alt="{{ contributor.login }} avatar" /></a>
  </li>
{% endfor %}
</ul>
