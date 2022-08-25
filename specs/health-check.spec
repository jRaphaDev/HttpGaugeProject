# HealthCheck - Gauge with RestCharp

This is an executable specification file. This file follows markdown syntax.
Every heading in this file denotes a scenario. Every bulleted point denotes a step.

To execute this specification, run

    gauge run specs

    
    |basePath             |response|
    |---------------------|--------|
    |http://localhost:3000|OK      |
    |http://localhost:3000|OK      |
    |http://localhost:3000|OK      |

## HealthCheck 200 - OK

* Should get the url <basePath>.
* The return must be <response>.