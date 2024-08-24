# Unity Coroutines
 Unity Coroutines


## Overview

This project contains two scripts for Unity:
1. `Mover`: Moves a GameObject back and forth between the mouse click position and its original position.
2. `GetMousePosition`: Captures the mouse position when the mouse button is clicked.

## Scripts

### Mover.cs

The `Mover` script is responsible for moving a GameObject between its original position and the position where the mouse was clicked. The movement is handled smoothly using coroutines.

#### Public Variables

- `moveDistance`: The distance the GameObject will move.
- `moveSpeed`: The speed at which the GameObject will move.
- `waitTime`: The time to wait at each position before moving.

#### Methods

- `Start()`: Initializes the original position and starts the movement coroutine.
- `Update()`: Continuously updates the position of the GameObject.
- `GetPosition()`: Gets the position of the mouse click using a raycast.
- `MoveBackAndForth()`: Coroutine that moves the GameObject back and forth between the current mouse click position and the original position.
- `MoveObject(Vector3 startPos, Vector3 endPos)`: Coroutine that handles the movement of the GameObject between two positions.

### GetMousePosition.cs

The `GetMousePosition` script captures the position of the mouse when it is clicked.

#### Properties

- `TargetPosition`: Stores the position of the mouse when clicked.

#### Methods

- `Update()`: This method is empty but could be used for future enhancements.
- `GetPosition()`: Returns the stored mouse position if the mouse button is pressed. Otherwise, returns the last stored position.

## Setup

1. Create a new Unity project or use an existing one.
2. Add two scripts to your project: `Mover.cs` and `GetMousePosition.cs`.
3. Attach the `Mover` script to the GameObject you want to move.
4. Attach the `GetMousePosition` script to any active GameObject in your scene (e.g., an empty GameObject).

## Usage

1. Click anywhere in the game view to set the target position.
2. The GameObject with the `Mover` script will move to the clicked position, wait for the specified time, and then move back to its original position.
3. The process will repeat indefinitely.

## Notes

- Ensure that your scene has a camera and that the `Camera.main` reference is correctly set.
- Adjust the `moveDistance`, `moveSpeed`, and `waitTime` in the `Mover` script to fit your needs.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

