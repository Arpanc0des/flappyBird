# 🐦 Flappy Bird

A Flappy Bird clone built in Unity while learning 2D game development.

![Unity](https://img.shields.io/badge/Unity-2022.3.43f1-000000?style=flat-square&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![version](https://img.shields.io/badge/version-0.1.0-blue?style=flat-square)

## Running it

Open the folder as a project in Unity **2022.3.43f1**, load
`Assets/Scenes/SampleScene.unity` and press play. Tap **space** to flap.

## What works so far

- The bird falls with gravity and flaps upward on space
- Pipes spawn on a timer at a random height
- Pipes scroll left and delete themselves once off screen

No scoring or game over yet — hitting a pipe currently does nothing.

## The scripts

| Script | What it does |
| --- | --- |
| `birdScript.cs` | Listens for space and sets the bird's upward velocity |
| `pipeSpawnScript.cs` | Spawns a pipe every `spawnRate` seconds at a random height within `heightOffset` |
| `pipeMotion.cs` | Moves a pipe left each frame, and destroys it past the `deadZone` |

All three expose their values as `public` fields, so speed, spawn rate and
spacing can be tweaked in the Unity inspector without touching the code.

## Versions

**0.1.0** — sprite gravity and collision set. Pipe spawn created and destroyed
off screen.

## What's next

- [ ] Game over when the bird hits a pipe or the ground
- [ ] Score counter for each pipe passed
- [ ] Start screen and restart button
- [ ] Background and ground sprites

## Credit

Followed [this tutorial](https://www.youtube.com/watch?v=XtQMytORBmM) to learn
the basics. Sprites from
[samuelcust/flappy-bird-assets](https://github.com/samuelcust/flappy-bird-assets).
