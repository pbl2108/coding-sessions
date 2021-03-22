from TestCase import TestCase
from WasRun import WasRun

class TestCaseTest(TestCase):
    def setUp(self):
        pass

    def testTemplateMethod(self):
        test = WasRun("testMethod")
        test.run(None)
        assert "setUp testMethod tearDown " == test.log, "Expected test to be set up, but found not to be set up"

TestCaseTest("testTemplateMethod").run(None)