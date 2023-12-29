all:
	quarto render
	quarto render --profile german
	quarto render --profile germanbook	
	quarto render --profile english	
	quarto render --profile englishbook	
	cp _book/de/IRTlib-Dokumentation--Software-für-die-Verwaltung-und-Auslieferung-computergestützter-Assessments.pdf _site/de/IRTlib-Dokumentation.pdf
	cp _book/en/IRTlib-Documentation--Software-for-the-administration-and-delivery-of-computer-based-assessments.pdf _site/en/IRTlib-Documentation.pdf
	cp -R _book/de/site_libs/ _site/site_libs/
	cp -R _book/de/site_libs/ _site/de/site_libs/
	cp -R _book/de/site_libs/ _site/en/site_libs/
	echo "www.irtlib.net" > _site/CNAME

de:
	quarto render --profile language 
	quarto render --profile german	
	quarto render --profile germanbook
	cp _book/de/IRTlib-Dokumentation--Software-für-die-Verwaltung-und-Auslieferung-computergestützter-Assessments.pdf _site/de/IRTlib-Dokumentation.pdf

en:
	quarto render --profile language 
	quarto render --profile english	
	quarto render --profile englishbook
	cp _book/en/IRTlib-Documentation--Software-for-the-administration-and-delivery-of-computer-based-assessments.pdf _site/en/IRTlib-Documentation.pdf
	
web: 
	quarto render
	quarto render --profile german
	quarto render --profile english	
  
book: 
	quarto render --profile germanbook	
