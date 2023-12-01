Simplest ReactiveUI Blazor App Ever!
====================================

Hey There! 👋
-------------

Welcome to my little sandbox where I play around with ReactiveUI and Blazor. It's not much, but it's honest work.

What's Cooking? 🍳
------------------

-   Reactive Commands: Like a remote control for your UI, but way cooler.
-   Dynamic UI Magic: Watch the UI change as if by magic! (It's actually ReactiveUI, but let's keep that our little secret).
-   User Fun Time: Type stuff, click a button, and voila! Stuff happens!

Getting Started (Easy-Peasy) 🚀
-------------------------------

### Stuff You Need

-   A computer (duh!)
-   .NET 6.0 or some such fancy thing
-   Visual Studio or VSCode (Yes, the free one works too!)

### How to Make It Run

1.  Snatch the code:

    bashCopy code

    `git clone https://github.com/yourusername/ReactiveUITest.git`

2.  Open it in that editor you just installed.
3.  Click on some buttons to make it build and run.
4.  Feel like a wizard when it actually works.

How to Play 🎮
--------------

-   There's a text box. You can type stuff in it.
-   Then there's a button. Click it and see the magic (Don't worry, it's just an alert, nothing scary).

Behind the Scenes 🎬
--------------------

### TestViewModel

-   The brain of the operation. Not very big, but it gets the job done.
-   It's got this `ReactiveCommand` thing. I press the button, it does stuff. Neat!

### TestService

-   The little guy that whispers to everyone when something changes.
-   Uses some Rx sorcery to notify stuff.

### Blazor Page (rxui)

-   Where the magic happens. Text field, button, alert -- the whole shebang.
-   It's hooked up to `TestViewModel` and listens to its every command.

Join the Party 🎉
-----------------

Wanna add some sparkles? Go ahead:

1.  Fork it (It's like stealing, but legal).
2.  Make your own branch (Branch out, get it?).
3.  Do your thing.
4.  Send it back to me -- I promise I'll look at it.

License
-------

It's under [MIT License](https://chat.openai.com/c/LICENSE). That means you can do pretty much whatever you want with it. Just don't sell it to evil corporations, okay?

Holler at Me 📢
---------------

Got questions? Ideas? Jokes? Send them all to [Mateus Morais](https://github.com/moraismateus).
