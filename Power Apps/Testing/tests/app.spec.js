const { test, expect } = require('@playwright/test');

let config = {
  appUrl: 'https://make.preview.powerapps.com/environments/c7493d59-4243-e6ac-8770-759287a2a011/home',
  appName: 'SW Accounts',
  signInUrl: 'https://portal.office.com/',
  username: 'aaschauer@D365DEMOTSS356396.OnMicrosoft.com',
  password: 'aa#017Kralerhof'
};


test.beforeEach(async ({ page }) => {
	// Open the sign in URL
	await page.goto(config.signInUrl);
	
	// Complete sign in flow
	await page.fill('input[name="loginfmt"]', config.username);
	await page.click('input[value=Next]');
	
	await page.fill('input[name="passwd"]', config.password);
	await page.click('input[value="Sign in"]');
	await page.waitForTimeout(10000);

});

test('Open SW App', async ({ page }) => {
    	// Open the app
	await page.goto(config.appUrl);

	// Look for the app name
	await expect(page.locator(`[data-id]=${config.appName}`).first()).toBeVisible();
});


test('create a contact', async ({ page }) => {
	// Open the contacts area from the sitemap
	await page.goto(config.appUrl);
	await page.waitForNavigation(),
	await page.click('text=Accounts');
	await page.waitForNavigation(),
	
	// Click on the New button in the command bar
	await page.click('[aria-label="New"]')
	await page.waitForNavigation(),
	
	// Complete some details on the contact form
	await page.fill('[aria-label="Account Name"]', 'Swarovski Optik');
	await page.fill('[aria-label="Address 1: Street 1"]', 'Wattens');
	
	// Click on the Save button in the command bar
	await page.click('[aria-label="Save (CTRL+S)"]')
	await page.waitForNavigation(),
	
	// Check if the next form contains the contacts ID
	await page.waitForFunction('Xrm.Utility.getPageContext().input.entityId !== null');
});