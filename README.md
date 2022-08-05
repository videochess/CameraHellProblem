# CameraHellProblem
the goal is to achieve player movement relative to a given completely static perspective camera.

currently, the character's horizontal movement is perfect, moving straight along a horizontal line.
however, vertical movement does not travel along a perfect line - it gets skewed the further you get away from the center of the camera.

is it possible to achieve perfectly straight up/down movement???

player movement script is PlayerMovement.cs, attached to PlayerCapsule object.
current move direction is drawn with a yellow debug ray when moving.