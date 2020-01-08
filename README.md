# BergPerformanceProfiler [![Build status](https://ci.appveyor.com/api/projects/status/32r7s2skrgm9ubva/branch/master?svg=true)](https://ci.appveyor.com/project/sLill/bergperformanceprofiler)
 A library of controls for use in monitoring cross-process or same-process performance.
 
 ## Local Machine - Same Process
 - <b>Flexible Performance UI controls</b> can be imported and embedded into user applications for quick lightweight
   analysis during run-time.
 - Alternatively, BergPerformanceServices can be ran without UI to export raw data to file  
 
 ## Local Machine - Foreign Process
 - Calls made through BergPerformanceServices broadcast performance information through named pipes
   to BergControls running in other processes on the local machine
 - <b>Frequency and control</b> over what data is sent made available as parameters 
 - <b>Watches</b> allow for measurement of specific regions of code and can be collected, compared
   and analyzed separately from other data being sent within the same process.

## Remote Machine - Foreign process (In development)
