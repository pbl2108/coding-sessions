from TestCase import TestCase
from WasRun import WasRun

class TestCaseTest(TestCase):
    def testRunning(self):
        test = WasRun("testMethod")
        assert not test.wasRun, "Expected test.wasRun to be false, but found true"
        test.run()
        assert test.wasRun, "Expected test.wasRun to be true, but found false"
TestCaseTest("testRunning").run()
