# BinDocConverter
## Still Under Development
## Use DotNet Framework based DCon [https://github.com/DouglasFeaster/DCon]

.gitconfig
```git
# .gitconfig file in your home directory
[diff "bindocconverter"]
  textconv=bindocconverter
  prompt = false
[alias]
  docdiff = diff --word-diff=color --unified=1
```

.gitattributes
```git
# .gitattributes file in root folder of your git project
    *.docx diff=bindocconverter
    *.docm diff=bindocconverter
    *.doc diff=bindocconverter
    *.dotx diff=bindocconverter
    *.dotm diff=bindocconverter
    *.dot diff=bindocconverter
    *.rtf diff=bindocconverter
    *.odt diff=bindocconverter

    *.xlsx diff=bindocconverter
    *.xlsm diff=bindocconverter
    *.xlsb diff=bindocconverter
    *.xls diff=bindocconverter
    *.csv diff=bindocconverter
    *.xltx diff=bindocconverter
    *.xltm diff=bindocconverter
    *.xlt diff=bindocconverter
    *.ods diff=bindocconverter 
    
    *.pptx diff=bindocconverter
    *.pptm diff=bindocconverter
    *.ppt diff=bindocconverter
    *.potx diff=bindocconverter
    *.potm diff=bindocconverter
    *.pot diff=bindocconverter
    *.ppsx diff=bindocconverter
    *.ppsm diff=bindocconverter
    *.pps diff=bindocconverter
    *.odp diff=bindocconverter
    
    *.pdf diff=bindocconverter
```
