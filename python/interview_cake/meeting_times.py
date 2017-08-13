import unittest

def find_meeting_times(times):
    times.sort()

    merged_meetings = [times[0]]

    for current_start, current_end in times[1:]:
        last_merged_start, last_merged_end = merged_meetings[-1]

        if current_start <= last_merged_end:
            merged_meetings[-1] = (last_merged_start,
                                   max(current_end, last_merged_end))
        else:
            merged_meetings.append(current_start, current_end)

    return merged_meetings


class MeetingTimes(unittest.TestCase):
    def test_find_meeting_times(self):
        meeting_list = [(2, 4), (1, 3)]
        assert find_meeting_times(meeting_list) == [(1, 4)]


def main():
  unittest.main()

if __name__ == '__main__':
    main()