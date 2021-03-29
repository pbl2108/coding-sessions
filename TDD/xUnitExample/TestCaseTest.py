from TestCase import TestCase
from WasRun import WasRun
from TestResult import TestResult
from TestSuite import TestSuite

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

    def testSuite(self):
        suite = TestSuite()
        suite.add(WasRun("testMethod"))
        suite.add(WasRun("testBrokenMethod"))
        result = TestResult()
        suite.run(result)
        assert "2 run, 1 failed" == result.summary(), "Expected summary to be '2 run, 1 failed', found something else"

suite = TestSuite()
suite.add(TestCaseTest("testTemplateMethod"))
suite.add(TestCaseTest("testResult"))
suite.add(TestCaseTest("testFailedResult"))
suite.add(TestCaseTest("testFailedResultFormatting"))
suite.add(TestCaseTest("testSuite"))
result= TestResult()
suite.run(result)
print(result.summary())