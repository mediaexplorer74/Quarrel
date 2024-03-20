# Quarrel
My fork of Quarell project for my own micro-research.

## About
A discord client for the Universal Windows Platform.  
Store link: https://www.microsoft.com/en-gb/p/quarrel-unofficial-discord-client/9nbrwj777c8r

![image](/Images/shot01.png)
![image](/Images/shot02.png)

## Tech details
- Os Win. build (target)  set at (to) 18362.
- Min. Win. Os win build (target) set at (to) 15063.
- iPhone SE LoginPage "emulation" added (old sweet user-agent "mechanics" used) 
- Precompiled WebRTC libs deleted for repo size optimization (locate them at original https://github.com/WinAppCommunity/Quarrel/tree/insider and use them for compilation succeess).
- WebView control damaged, no ipHoneEmulation. You need temporally inject your Discord token into LoginPage.cs :
```
 private async Task<string> GetTokenFromWebView()
 {
     // Discord doesn't allow access to localStorage so create an iframe to bypass this.
     string token = "paste your token here";
     ...
```

## Status
Early bird. Draft. No W10M testing yet.


## Reference(s)
https://github.com/WinAppCommunity/Quarrel/tree/insider Quarrel Insider branch (Discontinued/Obsolete W10M-compatible project)

## .
As is. No support. RnD only. DIY.

## ..
[m][e] 2024
