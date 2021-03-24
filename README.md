# Microscope DataManager Libs #

> Last Editor: [sunist-c](https://github.com/sunist-c)
>
> Last Edit: 2021-3-23



## Summary ##

This lis is using to manage the Microscope-Simulator Data, which including data description, slice source, thumbnail source, etc.

The namespace of the lib is `MDML`, yet NOT support RESTful APIs, just use `Config` class to change the default directory path.

## Structures ##

The lib contains following parts:

+ [x] XmlFile Reader/Writer
+ [x] MetaData Coder/Decoder
+ [x] Resource Package System
+ [x] Format Convertor

`XmlFile Reader/Writer` is based on `System.Xml`, which can read a xml document; \
 `MetaData Coder/Decoder` is based on `System.IO` and `Nuget Package`, which can Encode/Decode the raw materials;  \
`Resource Package System` is based on `System.Zip`, which can pack/unpack raw materials to a package; \
`Format Convert` is `base on basic convert algorithm, which can convert raw materials to its correct format from other format.

The extension name of our resource package is `.msd`, which means `MicroScpoeData`. 

In `PackageName.msd` package, which original format is `ZIP`, there have three contents:

+ Description.xml
+ Thumbnail.res
+ Metadata.res

`Description.xml` is the summary of the package, coding by `UTF-8`; `Thumbnail.res` is the raw materials of the slice thumbnail, original format is `PNG`; `Metadata.res` is the raw materials of the slice data, original format is `PNG`.

## Config ##

Default directory path of the lib is `~/Documents/MicroscopeData`, all the microscope data will be saved in this directory.

You can change DefaultPath like this:

```cs
using MDML.Config;

Method() {
    Config.DefaultPath = $"{YOUR_PATH}";
}
```

## Contact ##

[sunist - sunist.c@outlook.com](mailto:sunist.c@outlook.com)

## Copyrights ##

This project is commercial, which copyright by (SWU) Southwest University, China.


<details>
  
  <summary>Ptilopsis is under my desk</summary>

```txt
                                     0,    G          .CL;            
                       fCCC         fCC8 ;.::    000Gi18008LL         
                       ;CCCfLi1ii1tii8CG....;: 80         .80L        
             :8fi,......,;L00........,..L...L101            0Ct       
              CC.......................:  ,,8,0              0f,      
                88:.........            t :   0         ;00G.8f       
                   188C1t,  ;,,..    ...:,,8           ,:00,0Lf       
                  ,C,,,,,,,,i1:;;.f.,,,,f..tC           ,008CC        
                 ft,,,,,....f00C8i: ;f11G..1,f   000Gtf8088C1         
               C;;t....1...., 1i.;    ,i...i.8G G8.00                 
            LCCCii.1....f...GGCC:,.:tLL L .f CC8 :Gf                  
                  LG8C8C81;  .it;i1 GG1f LC0     CC                   
                     f8811i81LLt8tG1CGiifC81,.GC88i                   
                       ttCCL11tiiGC88;f18iCCCCCCC8CL                  
                    GCCC;L1Ciii1t tC8C.GCi1LC; 8CC;                   
                 :CCfGCCCL111:11   .;Ci G     ,C                      
                  CCCCCCLt1t11i.    f Li,ff,  C;                      
                  ,8C88Gt8CCCC,     C  ,ftLCfC8                       
                     ffffffff       .   ;f;iLCCC.                     
                  ,CCCC8GCCC: .      ,.:f,C;;iCi8i                    
                    LCCi;;t t:;.it,,i1; i L88,.                       
                        f    L             8G                         
                    ft,i;:1:G          :::;:;                         
                   80CCC;;it         ,tifGCtfCC                       
                   @00CCtLGtt         00CCC1GCf                       
                   08CCCL0CG           L8CCCCCG                       
                  00CCCCC0              0CCCCCGi                      
                 ,L.  iLCC             f0CCCCGG8                      
```

</details>