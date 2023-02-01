# Technical Tasks on Junior\Middle .NET 

## Task#1

#### Library project is AreaCalculatorLibrary

I wasn't sure what does "без знания типа фигуры в compile-time" means, cause there is more than one possible intended interpretations

So firstly I implemented simple abstaction approach with IShapeWithArea interface. So Users of that library can have runtime-defined shapes stored in IShapeWithArea type variables.

After some time thinking I also implemented Calculator class through which Users can have fluent\chain-based access to all library functionality. As it is fluent\chain-based - it can be easily scaled.

So Calculator class is responsible for easy-access to functionality and classes that implement IShapeWithArea is responsible for calculations itself.


#### Tests project is AreaCalculatorLibrary.Tests

There is a bunch of tests for shapes, and even A test of getting access to random runtime-defined shapes via IShapeWithArea interface.
Some of test likely redundant, as tests of Calculator class which ensures that all chaining methods retuns right types.


## Task#2

In the root folder there is CreateTables.sql and Query.sql files. 
Inside first file is sql script that creates tables that I used writing Query.sql script that contains requested query that selects product-category couples.


## Time spent

Firstly I spent ~1.5 hours on reading Task and implementation of shapes and interface and then ~1 hour on test writing.
Secondly there was ~0.5 hours for fixing after some tests failes (I didn't implement fool-proof checks first)
Then ~15 minutes was spent on Task#2 
After that and in between I was thinking about "без знания типа фигуры в compile-time" requirement and better user-side expirience and decided to impelemnt and write tests for fluent\chain-based Calculator class
I never before implemented such stuff by myself so it took some time to figure it out (~2-3 hours). Ever so I'm not sure I did it right, but I used lazy singletons and stuff, so I think perfomance is okay.

Tidying up solution and writing this readme took around an hour.

So comprehension + implementation + finalization took a total of 7 hours

## Addition

I was thinking about adding nuget-like publishing profile and "clint-side" project that will kinda use the library, but I did not, cause I decided it will be redundant.