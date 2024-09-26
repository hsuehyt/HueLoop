# Hue Loop Script

This Unity script smoothly animates the hue of any material that has a "Tint Color" property, creating a dynamic color transition over time. The effect is similar to RGB lighting where the colors gradually change in a loop.

## Features

- **Real-time Hue Shifting**: The script continuously cycles through the hue spectrum, providing a dynamic and colorful effect.
- **Customizable Speed**: The speed of the hue change can be adjusted through the `hueSpeed` parameter.

## Requirements

- Unity 2020 or later
- A material with a "Tint Color" property that will be animated by the script.

## How to Use

1. **Attach the Script**:
   - Add the `HueLoop` script to an empty GameObject in your scene.

2. **Assign the Material**:
   - In the inspector, assign any material that you want to animate. The material must have a "Tint Color" property that the script will update.

3. **Adjust Speed** (optional):
   - Set the `hueSpeed` parameter to control how fast the hue changes. The default value is `1.0`, but you can adjust it based on your needs.
