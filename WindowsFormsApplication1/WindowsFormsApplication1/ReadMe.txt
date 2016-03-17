Extra Features:
	1: Universes keep living cells across resizes if there would be no clipping with the new size
	2: Resize can run even if the simulation is running, it will pause the simulation, wait for it to finish the current thread, then resize the world
	3: Save takes in the minimum required size of the universe to be saved to file
	4: On load, as long as the universe is large enough, the file will be loaded to the center of the universe, otherwise it will resize the universe
	5: Clicking and dragging along the grid will 'paint' a line along the path