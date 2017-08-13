import unittest

# Most inefficient
# go through

def product_beside_index(provided_list):
    if len(provided_list) < 2:
        raise IndexError('Need at least 2 numbers')

    products_of_all_ints_except_index = [None] * len(provided_list)

    product_so_far = 1
    i = 0
    while i < len(provided_list):
        products_of_all_ints_except_index[i] = product_so_far
        product_so_far *= provided_list[i]
        i += 1

    product_so_far = 1
    i_2 = len(provided_list) - 1
    while i_2 >= 0:
        products_of_all_ints_except_index[i_2] *= product_so_far
        product_so_far *= provided_list[i_2]
        i_2 -= 1

    return products_of_all_ints_except_index



class ProductTests(unittest.TestCase):
    def test_product_beside_index(self):
        test_list = [1, 7, 3, 4]
        assert product_beside_index(test_list) == [84, 12, 28, 21]

def main():
    unittest.main()

if __name__ == '__main__':
    main()