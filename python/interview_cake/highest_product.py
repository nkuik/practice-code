from itertools import islice

list_of_integers = [2, 5, 6, 6, 32, 61, 36, 26, 12]

def find_highest_product(int_list):
    """

    :type int_list: object
    """

    if len(int_list) < 3:
        raise Exception('Less than 3 numbers')

    lowest = min(int_list[0], int_list[1])
    highest = max(int_list[0], int_list[1])

    highest_product_of_2 = int_list[0] * int_list[1]
    lowest_product_of_2 = int_list[0] * int_list[1]

    highest_product_of_3 = int_list[0] * int_list[1] * int_list[2]

    int_list.sort()

    for current in int_list[1:]:
        highest_product_of_3 = max(
            highest_product_of_2 * current,
            lowest_product_of_2 * current,
            highest_product_of_3
        )


        highest_product_of_2 = max(
            highest_product_of_2,
            lowest * current,
            highest * current
        )

        lowest_product_of_2 = min(
            lowest_product_of_2,
            lowest * current,
            highest * current
        )

        highest = max(highest, current)
        lowest = max(lowest, current)

    return highest_product_of_3


print(find_highest_product(list_of_integers))