---
title: Contributing guidelines
description: >-
  This API is an open-source project.
  Learn how to contribute issues, fixes, new indicators, new features, or to our discussions.
permalink: /contributing/
relative_path: contributing.md
layout: page
---

# Contributing guidelines

**Thanks for taking the time to contribute!**

This project is simpler than most, so it's a good place to start contributing to the open source community, even if you're a newbie.

We are accepting these sorts of changes and requests:

- Bug reports and fixes
- Usability improvements
- Documentation updates

We are not accepting things that should be done in your own wrapper code:

- Personal customizations and preferences
- Modified or augmented outputs that are not intrinsic

If you have general interest in contributing, but are not sure where to start, please [contact us](#contact-info) and we can help to find work in an area of interest.

## Reporting bugs and feature requests

If you suspect a problem, please [report a bug Issue](https://github.com/DaveSkender/Stock.Indicators.Api/issues/new?labels=bug&template=bug_report.md) with a detailed description of the problem, steps to reproduce, code samples, and any reference materials.  For enhancements, [create a feature Issue](https://github.com/DaveSkender/Stock.Indicators.Api/issues/new?labels=enhancement&template=feature_request.md).

Use the [Discussions](https://github.com/DaveSkender/Stock.Indicators.Api/discussions) area for general ideation and help/usage questions.

## Project management

- Planned work is managed in [the backlog](https://github.com/users/DaveSkender/projects/1).
- Work items are primarily entered as Notes (not Issues), except where an issue or feature is user reported.  With that said, Notes can be converted to Issues if in-progress and collaborative discussion is needed.

## Developing

- Read this first: [A Step by Step Guide to Making Your First GitHub Contribution](https://codeburst.io/a-step-by-step-guide-to-making-your-first-github-contribution-5302260a2940).  I also have a discussion [on Forking](https://github.com/DaveSkender/Stock.Indicators/discussions/503) if you have questions.
- If you want to work on something specific, please mention your intention on the related [Issue](https://github.com/DaveSkender/Stock.Indicators/issues).  If an Issue does not exist for your contribution, please create one before starting.  This will help us reserve that feature and avoid duplicative efforts.
- Do not commingle multiple contributions on different topics.  Please keep changes small and separate.

### Local hosting

From the Visual Studio Solution Explorer, select the `Api` project and then `CTRL+F5` to launch the API.  Or use CLI:

```bash
dotnet build
dotnet run --project src/Api.csproj
```

- Root endpoint is hosted as `https://localhost:[port]` and should show a `API is functioning nominally` message in your browser.
- OpenAPI (Swagger) documentations is available on `https://localhost:[port]/swagger`

## Testing

- Review the `test` folder for examples of unit tests.  Just copy one of these.
- We expect all unit tests to execute successfully and all Errors and Warning resolved before you submit your code.
- Failed builds or unit testing will block acceptance of your Pull Request when submitting changes.

## Documentation

This site uses [GitHub Pages](https://pages.github.com) and [Jekyll](https://jekyllrb.com) construction with Front Matter.
The documentation site is in the `docs` folder.  Build the site locally to test that it works properly.
See GitHub documentation for initial [Ruby and Jekyll setup instructions for Github Pages](https://docs.github.com/en/pages/setting-up-a-github-pages-site-with-jekyll/testing-your-github-pages-site-locally-with-jekyll).

```bash
# from /docs folder
bundle install
bundle exec jekyll serve

# then open site on http://127.0.0.1:4000
```

### Accessibility testing

- use Lighthouse in Chrome, or
- build the site locally (see above), then:

```bash
npx pa11y-ci --sitemap http://127.0.0.1:4000/sitemap.xml
```

## Submitting changes

By submitting changes to this repo you are also acknowledging and agree to the terms in both the [Developer Certificate of Origin (DCO) 1.1](https://developercertificate.org) and the [Apache 2.0 license](https://opensource.org/licenses/Apache-2.0).  These are standard open-source terms and conditions.

When ready, submit a [Pull Request](https://help.github.com/pull-requests) with a clear list of what you've done.
Always write a clear log message for your commits. One-line messages are fine for most changes.

After a Pull Request is reviewed, accepted, and [squash] merged to `main`, we may batch changes before publishing a new packaged version.  Please be patient with turnaround time.

## Code reviews and administration

If you want to contribute administratively, do code reviews, or provide general user support, we're also currently seeking a few core people to help.  Please [contact us](#contact-info) if interested.

## Standards and design guidelines

- [Guiding principles for this project](https://github.com/DaveSkender/Stock.Indicators.Api/discussions/7)
- [.NET Framework Design Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines)

## License

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

This repository uses a standard Apache 2.0 open-source license.  It enables open-source community development by protecting the project and contributors from certain legal risks while allowing the widest range of uses, including in closed source software.  Please review the [license](https://opensource.org/licenses/Apache-2.0) before using or contributing to the software.

## Contact info

[Start a new discussion](https://github.com/DaveSkender/Stock.Indicators.Api/discussions) or [submit an issue](https://github.com/DaveSkender/Stock.Indicators.Api/issues) if it is publicly relevant.  You can also direct message [@daveskender](https://twitter.com/messages/compose?recipient_id=27475431).

Thanks,
Dave Skender
