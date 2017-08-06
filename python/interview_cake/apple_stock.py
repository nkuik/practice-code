# take away order and you don't know when the time is
# one possibility is to go through every pair and make a comparison
# you have to compare every single pair then though.

prices = [0, 5, 6, 2, 98, 92, 3, 5, -3]

def get_max_profit_v1(prices):
    if len(prices) < 2:
        raise IndexError('Need at least 2 prices')

    min_price = 0
    max_profit = prices[1] - prices[0]

    for index, price in enumerate(prices):
        if index == 0:
            continue

        potential_profit = price - min_price
        max_profit = max(max_profit, potential_profit)
        min_price = min(price, min_price)

    return max_profit

print(get_max_profit_v1(prices))
