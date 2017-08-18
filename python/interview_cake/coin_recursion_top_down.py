import unittest

class CoinCounter:
    def __init__(self):
        self.keep_tracker = {}

    def number_of_ways(self, amount_left, coin_vector, index=0):

        way_key = (amount_left, index)

        if way_key in self.keep_tracker:
            print('fetching memo key: {}'.format(way_key))
            return self.keep_tracker[way_key]

        if amount_left == 0: return 1

        if amount_left <= 0: return 0

        if index == len(coin_vector): return 0

        print('checking number of ways to make {} with {}'.format(
              amount_left, coin_vector[index:]))

        current_coin = coin_vector[index]

        way_count = 0
        while amount_left >= 0:
            way_count += self.number_of_ways(amount_left, coin_vector, index + 1)
            amount_left -= current_coin

        self.keep_tracker[way_key] = way_count
        return way_count


class CoinTester(unittest.TestCase):
    def test_number_of_ways(self):
        counter = CoinCounter()
        print(counter.number_of_ways(8, [1, 3, 4]))
        # assert number_of_ways(4, [1,2,3]) == 4


def main():
    unittest.main()

if __name__ == '__main__':
    main()
