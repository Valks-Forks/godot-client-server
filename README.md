# Godot 4: Game + Server

My first attempt at programming a Client-Server socket, using the Godot's API for client-side stuff and standard C#'s UDP for Server side

My plan here is to create a template for any multiplayer game idea that I might have in the future. Building the server in standard C# in order to make the server more engine-agnostic.

**.NET Version:** `7`

**Godot Version:** `4.0.3.stable.mono`


**NOTE:** this is very much a test, so far the server works but once players disconnect, the server does not *actually* disconnect them.
