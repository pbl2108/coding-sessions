from TestCase import TestCase
from WasRun import WasRun

class TestCaseTest(TestCase):
    def setUp(self):
        self.test = WasRun("testMethod")

    def testRunning(self):
        self.test.run()
        assert self.test.wasRun, "Expected test.wasRun to be true, but found false"

    def testSetUp(self):
        self.test.run()
        assert self.test.wasSetUp, "Expected test.wasSetUp to be true, but found false"

TestCaseTest("testRunning").run()
TestCaseTest("testSetUp").run()