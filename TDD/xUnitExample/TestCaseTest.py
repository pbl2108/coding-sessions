from TestCase import TestCase
from WasRun import WasRun
from TestResult import TestResult

class TestCaseTest(TestCase):
    def setUp(self):
        pass

    def testTemplateMethod(self):
        test = WasRun("testMethod")
        test.run()
        assert "setUp testMethod tearDown " == test.log, "Expected test to be set up, but found not to be set up"

    def testResult(self):
        test=WasRun("testMethod")
        result=test.run()
        assert "1 run, 0 failed" == result.summary(), "Expected summary to be '1 run, 0 failed', found something else"

    def testFailedResult(self):
        test=WasRun("testBrokenMethod")
        result=test.run()
        assert "1 run, 1 failed" == result.summary(), "Expected summary to be '1 run, 1 failed', found something else"

    def testFailedResultFormatting(self):
        result = TestResult()
        result.testStarted()
        result.testFailed()
        assert "1 run, 1 failed" == result.summary(), "Expected summary to be '1 run, 1 failed', found something else"

TestCaseTest("testTemplateMethod").run()
TestCaseTest("testResult").run()
TestCaseTest("testFailedResult").run()
TestCaseTest("testFailedResultFormatting").run()