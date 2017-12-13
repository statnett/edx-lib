# EDX extension for AmqpNetLite

This is a small extension over AmqpNetLite for simplifying communication with an EDX-Toolbox. The most important part is encapsulating AMQP Application Properties that regularly would be [string-based](EdxLib/Constants.cs)

### Contents
There are four projects in this solution: 
1. [EdxLib](tree/master/EdxLib), the library itself
1. [EdxLibTests](tree/master/EdxLibTests), unit tests for the library
1. [SimpleSender](tree/master/SimpleSender), a simple example for sending data 
1. [SimpleReceiver](tree/master/SimpleReceiver), a simple example for receiving data

Additionaly there is help on setting up a [stub environemnt](tree/master/SETUP.md) for local development/testing

For more complex examples, see the AmqpLiteNet home, which contains more complex send/receive examples. One example of transactional communication is also given:
https://github.com/Azure/amqpnetlite/tree/master/test/Test.Amqp.Net

The samples on these pages are synchronous, synchronous, but amqpnetlite is encouraging use of async methods where available:
http://azure.github.io/amqpnetlite/articles/building_application.html

There is also callback-based communication examples available: 
https://github.com/Azure/amqpnetlite/blob/master/Examples
