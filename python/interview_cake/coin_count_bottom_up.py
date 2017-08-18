import unittest

def coin_counter_bottom_up(amount, coins):
    ways_of_doing_n_cents = [0] * (amount + 1)
    ways_of_doing_n_cents[0] = 1

    for coin in coins:
        for higher_amount in range(coin, amount + 1):
            higher_remainder = higher_amount - coin
            ways_of_doing_n_cents[higher_amount] += ways_of_doing_n_cents[higher_remainder]

    return ways_of_doing_n_cents[amount]

class CoinCounter(unittest.TestCase):
    def test_coin_counter_bottom_up(self):
        assert coin_counter_bottom_up(4, [1,2,3]) == 4


def main():
    unittest.main()


if __name__ == '__main__':
    main()