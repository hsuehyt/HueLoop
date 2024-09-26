# Hue Loop Script

This Unity script smoothly animates the hue of a skybox material that has a "Tint Color" property, creating a dynamic color transition over time. The effect is similar to RGB lighting where the colors gradually change in a loop.

## Features

- **Real-time Hue Shifting**: The script continuously cycles through the hue spectrum, providing a dynamic and colorful effect for the skybox.
- **Customizable Speed**: The speed of the hue change can be adjusted through the `hueSpeed` parameter.

## Requirements

- Unity 2020 or later
- A skybox material with a "_Tint" property.

## How to Use

1. **Attach the Script**:
   - Add the `HueLoop` script to an empty GameObject in your scene.

2. **Assign the Skybox Material**:
   - In the inspector, assign a skybox material that you want to animate. The material must have a `_Tint` property that the script will update.

3. **Adjust Speed** (optional):
   - Set the `hueSpeed` parameter to control how fast the hue changes. The default value is `1.0`, but you can adjust it based on your needs.

## Details

- The hue value loops between 0 and 1, ensuring a smooth transition through the full color spectrum.
- The converted hue is applied to the `_Tint` property of the skybox material in RGB format, keeping the saturation and value at maximum for vivid colors.
