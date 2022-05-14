# Intersections

This is my attempt at optimizing the OnTriggerXXX methods with pure math. I used information from **[this article](https://developer.mozilla.org/en-US/docs/Games/Techniques/3D_collision_detection)**, but with some improvements.
The project contains 4 scenes. Each scene is a test environment. 
- **"Pure"** is a pure scene with an empty objects generator. Used as a benchmark
- **"Colliders"** is a scene with the unity physics implementation.
- **"IntersectorsCore"** is the implementation of the used mathematics functions as is
- **"Intersectors"** is a math wrapper with an interface similar to Unity Collider.

I'm getting ~45 fps on the **IntersectorsCore** versus ~150 fps on the **Colliders** and see no reason to evolve the wrapper.
