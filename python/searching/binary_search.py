
def binary_search(given_list, num_searching):
    low = 0
    high = len(given_list) - 1

    while low <= high:
        mid = (low + high) // 2
        guess = given_list[mid]
        if guess == num_searching:
            return mid
        elif guess > num_searching:
            high = mid - 1
        else:
            low = mid + 1
    return -1

test_list = [1, 3, 5, 7, 9, 13, 25, 36]

assert binary_search(test_list, 25) == 6
assert binary_search(test_list, 4) == -1
assert binary_search(test_list, 7) == 3
