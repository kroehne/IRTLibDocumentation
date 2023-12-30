# IRTLibDocumentation

Suggested Citation:

> Kroehne, U. (2023). IRTlib Documentation: Software for the administration and delivery of computer-based assessments 
> [IRTlib Dokumentation: Software für die Verwaltung und Auslieferung computergestützter Assessments]. 
> DIPF, Frankfurt am Main, Germany. https://doi.org/10.5281/zenodo.10441352

## Folder Structure

Quarto Files (don't change):

- _quarto.yml: Main _quarto, defining title and default profile "language"
- _quarto-german.yml: Website German
- _quarto-english.yml: Website English
- _quarto-germanbook.yml: PDF German
- _quarto-englishbook.yml: PDF English

Index Files  (don't change):

- Entry points _index_de-DEU.qmd (https://kroehne.github.io/IRTLibDocumentation/de) and _index_en-US.qmd ((https://kroehne.github.io/IRTLibDocumentation/en) should have identical content.
- The _index_language.qmd file is the language selection file (https://kroehne.github.io/IRTLibDocumentation/)

Help Files

- All files starting with `InlineHelp*.html` are converted to HTML (with embedded resources) and added to *.resx-files (de-DEU: https://www.irtlib.net/Help.de-DE.resx, en-US: https://www.irtlib.net/Help.en-US.resx).
- Files ending with _de-DEU.qmd and _en-US.qmd should have identical content. German files are edited when new content is provided, English files should be updated.


Documentation Files:

- Files with _de-DEU.qmd and _en-US.qmd should have identical content (German files are edited first and translated second). 

|Topic|Source|Output|
|-----|------|------|
| Home | [de-DEU](https://github.com/kroehne/IRTLibDocumentation/blob/main/_index_de-DEU.qmd) [en-US](https://github.com/kroehne/IRTLibDocumentation/blob/main/_index_en-US.qmd) | [de-DEU](https://www.irtlib.net/de/) [en-US](https://www.irtlib.net/en/) |
| Download | [de-DEU](https://github.com/kroehne/IRTLibDocumentation/blob/main/_download_de-DEU.qmd) [en-US](https://github.com/kroehne/IRTLibDocumentation/blob/main/_download_en-US.qmd) | [de-DEU](https://kroehne.github.io/IRTLibDocumentation/de/download.html) [en-US](https://kroehne.github.io/IRTLibDocumentation/en/download.html) |
|Vorbereitung / Preparation | | |
| * Übersicht / Preparation | [de-DEU](https://github.com/kroehne/IRTLibDocumentation/blob/main/_preparation-overview_de-DEU.qmd) [en-US](https://github.com/kroehne/IRTLibDocumentation/blob/main/_preparation-overview_en-US.qmd) | [de-DEU](https://www.irtlib.net/de/preparation-overview.html) [en-US](https://www.irtlib.net/en/preparation-overview.html) |
| *  Studien / Preparation Studies | [de-DEU](https://github.com/kroehne/IRTLibDocumentation/blob/main/_preparation-studies_de-DEU.qmd) [en-US](https://github.com/kroehne/IRTLibDocumentation/blob/main/_preparation-studies_en-US.qmd) | [de-DEU](https://www.irtlib.net/de/preparation-overview.html) [en-US](https://www.irtlib.net/en/preparation-overview.html) |
| *  Erhebungsteile / Preparation | [de-DEU](https://github.com/kroehne/IRTLibDocumentation/blob/main/_preparation-parts_de-DEU.qmd) [en-US](https://github.com/kroehne/IRTLibDocumentation/blob/main/_preparation-parts_en-US.qmd) | [de-DEU](https://www.irtlib.net/de/preparation-parts.html) [en-US](https://www.irtlib.net/en/preparation-parts.html) |
|Datenerhebung / Data Collection| | |
|* Übersicht / Overview| [de-DEU](https://github.com/kroehne/IRTLibDocumentation/blob/main/_data-collection-overview_de-DEU.qmd) [en-US](https://github.com/kroehne/IRTLibDocumentation/blob/main/_data-collection-overview_en-US.qmd) | [de-DEU](https://www.irtlib.net/de/data-collection-overview.html) [en-US](https://www.irtlib.net/en/data-collection-overview.html) |
|* Veröffentlichen & Exportieren / Publish & Export| [de-DEU](https://github.com/kroehne/IRTLibDocumentation/blob/main/_data-collection-publish-and-export_de-DEU.qmd) [en-US](https://github.com/kroehne/IRTLibDocumentation/blob/main/_data-collection-publish-and-export_en-US.qmd) | [de-DEU](https://www.irtlib.net/de/data-collection-publish-and-export.html) [en-US](https://www.irtlib.net/en/data-collection-publish-and-export.html) |
|* Integration & Auslieferung / Integration & Deployment| [de-DEU](https://github.com/kroehne/IRTLibDocumentation/blob/main/_data-collection-overview_de-DEU.qmd) [en-US](https://github.com/kroehne/IRTLibDocumentation/blob/main/_data-collection-overview_en-US.qmd) | [de-DEU](https://www.irtlib.net/de/data-collection-player-integration.html) [en-US](https://www.irtlib.net/en/data-collection-player-integration.html) |
|*  Datenaufbereitung / Data Post-Processing  | [de-DEU](https://github.com/kroehne/IRTLibDocumentation/blob/main/_data-collection-post-processing_de-DEU.qmd ) [en-US](https://github.com/kroehne/IRTLibDocumentation/blob/main/_data-collection-post-processing_en-US.qmd ) | [de-DEU](https://www.irtlib.net/de/data-collection-post-processing.html) [en-US](https://www.irtlib.net/en/data-collection-post-processing.html) |
| Einstellungen / Settings | [de-DEU](https://github.com/kroehne/IRTLibDocumentation/blob/main/_settings_de-DEU.qmd) [en-US](https://github.com/kroehne/IRTLibDocumentation/blob/main/_settings_en-US.qmd) | [de-DEU](https://www.irtlib.net/de/settings.html) [en-US](https://www.irtlib.net/en/settings.html) | 
| Über/ About | [de-DEU](https://github.com/kroehne/IRTLibDocumentation/blob/main/_about_de-DEU.qmd) [en-US](https://github.com/kroehne/IRTLibDocumentation/blob/main/_about_en-US.qmd) | [de-DEU](https://www.irtlib.net/de/about.html) [en-US](https://www.irtlib.net/en/about.html) | 
| Translation| [en-US](https://github.com/kroehne/IRTLibDocumentation/blob/main/translation.qmd) |  [en-US](https://www.irtlib.net/en/translation.html) | 
| Github |[de-DEU](https://github.com/kroehne/IRTLibDocumentation/blob/main/_github_de-DEU.qmd) [en-US](https://github.com/kroehne/IRTLibDocumentation/blob/main/_github_en-US.qmd) | [de-DEU](https://www.irtlib.net/de/github.html) [en-US](https://www.irtlib.net/en/github.html) | 


