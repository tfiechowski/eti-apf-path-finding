# Artificial Potential Field for mobile robot path finding
A project showing the Artificial Potential Field method for robot path finding.

## Overview

There is a bright red robot on the field, and its goal is to reach the destination point showed in light green. 
It must avoid collision with the moving pendulum. Path finding and collision avoidance is accomplished by using
Artificial Potential Field method. 

## Artificial Potential Field method

All objects are modeled as potentials, thus affecting the robot with a force. Obstacles have negative charge 
and the destination point has a positive charge. Robot is respectively repelled or attracted by that objects. 
Thereby, the robot should avoid all obstacles and reach the destination point. 

## Usage guide

In the top left corner of the screen, there is a 'Start' button. It resets the simlation and randomly place
robot, pendulums and destination point. Robot will be spawned somewhere in the upper left corner, destination 
point in the lower left corner and pendulums will be created in the space between. 

Pendulums also have random maximum inclination and random angle of movement, so they oscillate both on x and y axis.
Random phase shift is added to the oscillation function to ensure random initial inclination.
Diameter of the pendulum is fixed to 40 px, twice the diameter of the robot. 

There is also a box to enter a number of pendulums in the field. 
