import unittest

def find_rectangle_overlap(rec_1, rec_2):
    pass


def overlap_helper(point_1, length_1, point_2, length_2):

    highest = max(point_1, point_2)
    lowest = max(point_1 + length_1, point_2 + length_2)

    if highest >= lowest: return(None, None)


class OverlapperTester(unittest.TestCase):
    def test_find_rectangle_overlap(self):
        test_overlap = {
            'left_x' = 3
            'bottom_y' = 2,
            'width' = 3,
            'height' = 4
        }

        assert find_rectangle_overlap() == test_overlap


def main():
    unittest.main()


if __name__ == '__main__':
    main()