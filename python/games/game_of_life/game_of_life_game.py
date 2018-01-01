import random

import game_of_life_rules as rules


class Game():
    def __init__(self, grid, simulation):
        self.grid = grid
        self.simulation = simulation

    def next_round(self):
        self.grid = rules.live_a_generation(self.grid, self.simulation)


def play_game():
    height = input('What height would you like?: ')
    width = input('What width would you like?: ')

    grid = rules.Grid(int(height), int(width))
    for _ in range(int(height)):
        grid.assign(random.randrange(int(height)),
                    random.randrange(int(width)),
                    rules.ALIVE)
    sim = rules.simulate(grid.height, grid.width)

    game = Game(grid, sim)

    print('Here is the grid:\n{}'.format(game.grid))

    keep_playing = True
    while keep_playing:
        persistence = input('Play another round? (y or n): ')
        if persistence == 'y':
            game.next_round()
            print('Here is the grid:\n{}'.format(game.grid))
        else:
            keep_playing = False
            print('Here is the final grid:\n{}'.format(game.grid))


if __name__ == '__main__':
    play_game()
