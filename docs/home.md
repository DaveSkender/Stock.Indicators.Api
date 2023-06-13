---
title: Stock Indicators API
description: >-
  Transform financial market prices into technical analysis insights with this self-hosted .NET API.
permalink: /
layout: base
lazy-images: true
---

<h1 style="display:none;">{{ page.title }}</h1>

**Stock Indicators API** is a REST API built with .NET that produces financial market technical indicators.  Send in historical price quotes and get back desired indicators such as moving averages, Relative Strength Index, Stochastic Oscillator, Parabolic SAR, etc.  Nothing more.

It can be used in any market analysis software using standard OHLCV price quotes for equities, commodities, forex, cryptocurrencies, and others.  We had private technical analysis, trading algorithms, machine learning, and charting systems in mind when originally creating this library.  [Stock Indicators for .NET](https://dotnet.stockindicators.dev/) is also available.

Explore more information:

- [Demo site](https://charts.stockindicators.dev/) (a stock chart)
- [Release notes]({{site.github.repository_url}}/releases)
- [Discussions]({{site.github.repository_url}}/discussions)
- [Contributing guidelines]({{site.baseurl}}/contributing/#content)

## Licensed for everyone

<a href="https://opensource.org/licenses/Apache-2.0"><img src="https://img.shields.io/badge/License-Apache%202.0-blue.svg?style=flat-square&cacheSeconds=259200" alt="Apache 2.0 license badge" width="124" height="20" class="lazyload" /></a>

This repository uses the standard Apache 2.0 open-source license.  Please review the [license](https://opensource.org/licenses/Apache-2.0) before using or contributing to the software.

## Share your ideas with the community

**Need help?**  Have ideas?  [Start a new discussion, ask a question &#128172;]({{site.github.repository_url}}/discussions), or [submit an issue]({{site.github.repository_url}}/issues) if it is publicly relevant.  You can also direct message [@daveskender](https://twitter.com/messages/compose?recipient_id=27475431).

## Give back with patronage

Thank you for your support!  This software is crafted with care by unpaid enthusiasts who &#128150; all forms of encouragement.  If you or your organization use this library or like what we're doing, add a &#11088; on the [GitHub Repo]({{site.github.repository_url}}) as a token of appreciation.

If you want to buy me a beer or are interested in ongoing support as a patron, [become a sponsor](https://github.com/sponsors/DaveSkender).  Patronage motivates continued maintenance and evolution of open-source projects, and to inspire new ones.

## Contribute to help others

This NuGet package is an open-source project [on GitHub](https://github.com/DaveSkender/Stock.Indicators).  If you want to report bugs or contribute fixes, new indicators, or new features, please review our [contributing guidelines]({{site.baseurl}}/contributing/#content) and [the backlog](https://github.com/users/DaveSkender/projects/1).

Special thanks to all of our community code contributors!

<ul class="list-style-none">
{% for contributor in site.github.contributors %}
  <li class="d-inline-block">
     <a href="{{ contributor.html_url }}" width="75" height="75"><img data-src="{{ contributor.avatar_url }}&s=75" width="75" height="75" class="circle lazyload" alt="{{ contributor.login }} avatar" /></a>
  </li>
{% endfor %}
</ul>

<!-- &#187; see our [full list of indicators and overlays]({{site.baseurl}}/indicators/#content) -->
