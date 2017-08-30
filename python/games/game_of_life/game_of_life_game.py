import random

import game_of_life_rules as game


def setup_game(height, width):
    grid = game.Grid(height, width)
    grid.assign(random.randrange(height),
                random.randrange(width),
                game.ALIVE)
    return grid


def play_game():
    height = input('What height would you like?: ')
    width = input('What width would you like?: ')
    grid = setup_game(int(height), int(width))
    sim = game.simulate(grid.height, grid.width)
    print('Here is the grid:\n{}'.format(grid))

    keep_playing = True
    while keep_playing:
        persistence = input('Play another round? (y or n): ')
        if persistence == 'y':
            game.live_a_generation(grid, sim)
            print('Here is the grid:\n{}'.format(grid))
        else:
            keep_playing = False
            print('Here is the final grid:\n{}'.format(grid))


if __name__ == '__main__':
    play_game()
